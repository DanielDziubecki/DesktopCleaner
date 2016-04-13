using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using SegragatorPulpitu.UI;

namespace SegragatorPulpitu
{
    public partial class DesktopCleaner : Form
    {
        #region Ini

        public DesktopCleaner()
        {
            InitializeComponent();
        }

        private void DesktopCleaner_Load(object sender, EventArgs e)
        {
            treeListFileExplorer.DataSource = new object();
            selectedPath = DesktopPath;
            Resfresh();
            iconRestorer = new IconRestorer.Code.IconRestorer();
            iconRestorer.SavePositions();
            oldAndNewPaths = new Dictionary<string, string>();
        }

        #endregion

        #region Fields

        private static readonly string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private readonly string mainFolderDestination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private string backupPath;
        private IconRestorer.Code.IconRestorer iconRestorer;
        private bool loadDrives;
        private string mainFolderFullPath;
        private string mainfolderName;
        private Dictionary<string, string> oldAndNewPaths;
        private string selectedPath;

        #endregion

        #region Methods

        public void CreateBackupFolder()
        {
            backupPath = Path.Combine(mainFolderDestination, "Kopia zapasowa");
            Directory.CreateDirectory(backupPath);
        }

        public void CreateFolders(Dictionary<string, List<string>> folderNameWithExtensions)
        {
            if (cbKopiaZapasowa.Checked)
            {
                CreateBackupFolder();
            }
            foreach (var folderNameWithExtension in folderNameWithExtensions)
            {
                var eachFolderPath = Path.Combine(mainFolderFullPath, folderNameWithExtension.Key);
                Directory.CreateDirectory(eachFolderPath);
                TransferFiles(folderNameWithExtension.Key, folderNameWithExtension.Value);
            }
        }

        public HashSet<string> GetFilesExtensions(string path)
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

        public void OpenSortedDirectory()
        {
            Process.Start("explorer.exe", mainFolderFullPath);
        }

        private void Clean()
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

                mainFolderFullPath = Path.Combine(mainFolderDestination, mainfolderName);
                if (Directory.Exists(mainFolderFullPath))
                {
                    MessageBox.Show(string.Format("Folder {0} już istnieje", mainfolderName));
                    return;
                }
                var foldersWithExtensions = GetSelectedExtensionsWithFolderNames();
                CreateFolders(foldersWithExtensions);
                Resfresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Wystąpił błąd");
            }
        }

        private void GenerateControls(HashSet<string> extensions)
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

        private Dictionary<string, List<string>> GetSelectedExtensionsWithFolderNames()
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

        private void Resfresh()
        {
            var extensions = GetFilesExtensions(selectedPath);
            GenerateControls(extensions);
        }

        private void RestoreFiles()
        {
            foreach (var paths in oldAndNewPaths)
            {
                if (File.Exists(paths.Value))
                {
                    File.Move(paths.Value, paths.Key);
                }
            }
            oldAndNewPaths.Clear();
        }

        private void RestoreIconArrangment()
        {
            iconRestorer.RestorePositions();
        }

        private void TransferFiles(string nestedFolderName, IEnumerable<string> extensions)
        {
            var destinationNestedFolderPath = Path.Combine(mainFolderFullPath, nestedFolderName);

            foreach (var extension in extensions)
            {
                var filesWithExtension = Directory.GetFiles(selectedPath, @"*." + extension);
                foreach (var file in filesWithExtension)
                {
                    var pathLentgh = file.Split(Path.DirectorySeparatorChar).Length;
                    var fileName = file.Split(Path.DirectorySeparatorChar)[pathLentgh - 1];
                    var fullFilePath = Path.Combine(destinationNestedFolderPath, fileName);
                    oldAndNewPaths.Add(file, fullFilePath);
                    if (cbKopiaZapasowa.Checked)
                    {
                        File.Copy(file, Path.Combine(backupPath, fileName));
                    }
                    File.Move(file, fullFilePath);
                }
            }
        }

        #endregion

        #region Actions

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            Resfresh();
        }

        private void btnPrzywroc_Click(object sender, EventArgs e)
        {
            RestoreFiles();
            Thread.Sleep(5000);
            RestoreIconArrangment();
        }

        private void btnSprzataj_Click(object sender, EventArgs e)
        {
            Clean();
            OpenSortedDirectory();
        }

        private void btnZapiszRozmieszczenie_Click(object sender, EventArgs e)
        {
            iconRestorer.SavePositions();
            MessageBox.Show("Zapisano");
        }

        private void treeListFileExplorer_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            selectedPath = GetFullPath(e.Node, @"\");
            var allExtensions = GetFilesExtensions(selectedPath);
            GenerateControls(allExtensions);
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