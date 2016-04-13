using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using SegragatorPulpitu.UI;

namespace SegragatorPulpitu
{
    public partial class Sprzatacz : Form
    {
        #region Ini

        public Sprzatacz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeListFileExplorer.DataSource = new object();
            selectedPath = DesktopPath;
            Odswiez();
            iconRestorer = new IconRestorer.Code.IconRestorer();
            iconRestorer.SavePositions();
            oldAndNewPaths = new Dictionary<string, string>();
        }

        #endregion

        #region Fields

        private static readonly string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private string backupPath;
        private IconRestorer.Code.IconRestorer iconRestorer;
        private bool loadDrives;
        private string mainfolderName;
        private string mainfolderPath;
        private Dictionary<string, string> oldAndNewPaths;
        private string selectedPath;

        #endregion

        #region Methods

        public string GetFullPath(TreeListNode node, string pathSeparator)
        {
            if (node == null) return "";
            var result = "";
            while (node != null)
            {
                var test = node.GetDisplayText(0);
                if (Regex.IsMatch(test, "[A-Z]?:"))
                {
                    result = node.GetDisplayText(0) + result;
                    return result;
                }
                result = pathSeparator + node.GetDisplayText(0) + result;
                node = node.ParentNode;
            }

            return result;
        }

        public HashSet<string> PobierzRozszerzeniaPlikow(string path)
        {
            var uniqueExtensions = new HashSet<string>();
            try
            {
                var files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    var fileName = file.Remove(0, path.Length + 1).ToLowerInvariant();
                    if (!NotNeededExtensions.WrongFileExtension.Any(fileName.Contains))
                    {
                        var dots = fileName.Split('.');
                        uniqueExtensions.Add(fileName.Split('.')[dots.Length - 1]);
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show(e.Message, @"Błąd");
            }


            return uniqueExtensions;
        }

        public void StworzFolderKopiiZapasowej()
        {
            backupPath = Path.Combine(selectedPath, "Kopia zapasowa");
            Directory.CreateDirectory(backupPath);
        }

        public void StworzFoldery(Dictionary<string, List<string>> rozszerzeniaZnazwaFolderu)
        {
            if (cbKopiaZapasowa.Checked)
            {
                StworzFolderKopiiZapasowej();
            }
            foreach (var rozszerzenieInazwa in rozszerzeniaZnazwaFolderu)
            {
                var eachFolderPath = Path.Combine(mainfolderPath, rozszerzenieInazwa.Key);
                Directory.CreateDirectory(eachFolderPath);
                PrzeniesPliki(rozszerzenieInazwa.Key, rozszerzenieInazwa.Value);
            }
        }

        private void GenerujKontrolki(HashSet<string> extensions)
        {
            if (!extensions.Any())
                return;
            lcgRozszerzenia.Clear();
            layoutControl1.BeginUpdate();
            var labels = new Labels();
            var lciLabels = lcgRozszerzenia.AddItem();
            lciLabels.Size = labels.Size;
            lciLabels.TextVisible = false;
            lciLabels.Control = labels;
            var i = 1;
            foreach (var eachExtension in extensions.Select(extension => new ExtensionsAndFolderNames(extension)))
            {
                eachExtension.Location = new Point(0, i*eachExtension.Height);
                var lciExtensionsAndFolderNames = lcgRozszerzenia.AddItem();
                lciExtensionsAndFolderNames.TextVisible = false;
                lciExtensionsAndFolderNames.Control = eachExtension;
                i++;
            }
            layoutControl1.EndUpdate();
        }

        private void Odswiez()
        {
            var rozszerzenia = PobierzRozszerzeniaPlikow(selectedPath);
            GenerujKontrolki(rozszerzenia);
        }

        private Dictionary<string, List<string>> PobierzWybraneRozszerzeniaINazwyFolderow()
        {
            var folderNameWithExtensions = new Dictionary<string, List<string>>();
            foreach (var control in layoutControl1.Controls.OfType<ExtensionsAndFolderNames>())
            {
                var checkBox = control.Controls.OfType<CheckEdit>().SingleOrDefault();
                if (checkBox != null && checkBox.Checked)
                {
                    var extensionList = new List<string> {checkBox.Name};
                    var texEdit = control.Controls.OfType<TextEdit>().SingleOrDefault();
                    if (texEdit != null)
                    {
                        if (folderNameWithExtensions.ContainsKey(texEdit.Text))
                        {
                            foreach (var extension in extensionList)
                            {
                                folderNameWithExtensions[texEdit.Text].Add(extension);
                            }
                        }
                        else
                        {
                            folderNameWithExtensions.Add(texEdit.Text, extensionList);
                        }
                    }
                }
            }
            return folderNameWithExtensions;
        }

        private void PrzeniesPliki(string nazwaFolderu, IEnumerable<string> rozszerzenia)
        {
            var mainFolderPath = Path.Combine(selectedPath, mainfolderName);
            var destinationFolderPath = Path.Combine(mainFolderPath, nazwaFolderu);

            foreach (var rozszerzenie in rozszerzenia)
            {
                var plikiZrozszerzeniem = Directory.GetFiles(selectedPath, @"*." + rozszerzenie);
                foreach (var file in plikiZrozszerzeniem)
                {
                    var pathLentgh = file.Split(Path.DirectorySeparatorChar).Length;
                    var fileName = file.Split(Path.DirectorySeparatorChar)[pathLentgh - 1];
                    var fullFilePath = Path.Combine(destinationFolderPath, fileName);
                    oldAndNewPaths.Add(file, fullFilePath);
                    if (cbKopiaZapasowa.Checked)
                    {
                        File.Copy(file, Path.Combine(backupPath, fileName));
                    }
                    File.Move(file, fullFilePath);
                }
            }
        }

        private void PrzywrocPliki()
        {
            foreach (var paths in oldAndNewPaths.Where(paths => File.Exists(paths.Value)))
            {
                File.Move(paths.Value, paths.Key);
                oldAndNewPaths.Remove(paths.Key);
            }
        }

        private void PrzywrocUstawienieIkon()
        {
            iconRestorer.RestorePositions();
        }

        private void Sprzataj()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNazwaFolderuGlownego.Text))
                {
                    mainfolderName = txtNazwaFolderuGlownego.Text;
                }
                else
                {
                    MessageBox.Show("Podaj nazwę folderu głównego");
                    return;
                }

                mainfolderPath = Path.Combine(selectedPath, mainfolderName);
                if (Directory.Exists(mainfolderPath))
                {
                    MessageBox.Show(string.Format("Folder {0} już istnieje", mainfolderName));
                    return;
                }
                var folderyZrozszerzeniami = PobierzWybraneRozszerzeniaINazwyFolderow();
                StworzFoldery(folderyZrozszerzeniami);
                Odswiez();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Wystąpił błąd");
            }
        }

        #endregion

        #region Actions

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void btnPrzywroc_Click(object sender, EventArgs e)
        {
            PrzywrocPliki();
            PrzywrocUstawienieIkon();
        }

        private void btnSprzataj_Click(object sender, EventArgs e)
        {
            Sprzataj();
        }

        private void btnZapiszRozmieszczenie_Click(object sender, EventArgs e)
        {
            iconRestorer.SavePositions();
            MessageBox.Show("Zapisano");
        }

        private void treeListFileExplorer_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            selectedPath = GetFullPath(e.Node, @"\");
            var allExtensions = PobierzRozszerzeniaPlikow(selectedPath);
            GenerujKontrolki(allExtensions);
        }

        private void treeListFileExplorer_VirtualTreeGetCellValue(object sender, VirtualTreeGetCellValueInfo e)
        {
            var di = new DirectoryInfo((string) e.Node);
            if (e.Column == treeListColumnFoldery)
            {
                e.CellData = di.Name;
            }
        }

        private void treeListFileExplorer_VirtualTreeGetChildNodes(object sender, VirtualTreeGetChildNodesInfo e)
        {
            if (!loadDrives)
            {
                var root = Directory.GetLogicalDrives();
                e.Children = root;
                loadDrives = true;
            }
            else
            {
                try
                {
                    var path = (string) e.Node;
                    if (Directory.Exists(path))
                    {
                        var dirs = Directory.GetDirectories(path);

                        var arr = new string[dirs.Length];
                        dirs.CopyTo(arr, 0);
                        e.Children = arr;
                    }
                    else e.Children = new object[] {};
                }
                catch
                {
                    e.Children = new object[] {};
                }
            }
        }

        #endregion

        #region Nested types

        public static class NotNeededExtensions
        {
            #region Fields

            public static readonly string[] WrongFileExtension = {".ini", ".lnk", ".appref-ms"};

            #endregion
        }

        #endregion
    }
}