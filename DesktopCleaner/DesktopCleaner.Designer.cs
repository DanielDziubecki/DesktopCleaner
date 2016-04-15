namespace SegragatorPulpitu
{
    partial class DesktopCleaner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopCleaner));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSprzataj = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdswiez = new DevExpress.XtraEditors.SimpleButton();
            this.cbKopiaZapasowa = new DevExpress.XtraEditors.CheckEdit();
            this.btnZapiszRozmieszczenie = new DevExpress.XtraEditors.SimpleButton();
            this.txtNazwaFolderuGlownego = new DevExpress.XtraEditors.TextEdit();
            this.btnPrzywroc = new DevExpress.XtraEditors.SimpleButton();
            this.treeListFileExplorer = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumnFoldery = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgRozszerzenia = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciZapiszRozmieszczenie = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPrzywroc = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSprzataj = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciKopiaZapasowa = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNazwaFolderuGlownego = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOdswiez = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.lcgKatalog = new DevExpress.XtraLayout.LayoutControlGroup();
            this.FileExplorer = new DevExpress.XtraLayout.LayoutControlItem();
            this.ListView = new DevExpress.XtraLayout.LayoutControlItem();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lastmodified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbKopiaZapasowa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNazwaFolderuGlownego.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListFileExplorer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRozszerzenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciZapiszRozmieszczenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrzywroc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSprzataj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKopiaZapasowa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNazwaFolderuGlownego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOdswiez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgKatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileExplorer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSprzataj);
            this.layoutControl1.Controls.Add(this.btnOdswiez);
            this.layoutControl1.Controls.Add(this.cbKopiaZapasowa);
            this.layoutControl1.Controls.Add(this.btnZapiszRozmieszczenie);
            this.layoutControl1.Controls.Add(this.txtNazwaFolderuGlownego);
            this.layoutControl1.Controls.Add(this.btnPrzywroc);
            this.layoutControl1.Controls.Add(this.treeListFileExplorer);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(632, 210, 480, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(711, 674);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSprzataj
            // 
            this.btnSprzataj.Image = global::SegragatorPulpitu.Properties.Resources.broom_32x32;
            this.btnSprzataj.Location = new System.Drawing.Point(24, 546);
            this.btnSprzataj.Name = "btnSprzataj";
            this.btnSprzataj.Size = new System.Drawing.Size(352, 38);
            this.btnSprzataj.StyleController = this.layoutControl1;
            this.btnSprzataj.TabIndex = 11;
            this.btnSprzataj.Text = "Sprzątaj!";
            this.btnSprzataj.Click += new System.EventHandler(this.btnSprzataj_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Image = ((System.Drawing.Image)(resources.GetObject("btnOdswiez.Image")));
            this.btnOdswiez.Location = new System.Drawing.Point(306, 24);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(70, 22);
            this.btnOdswiez.StyleController = this.layoutControl1;
            this.btnOdswiez.TabIndex = 10;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // cbKopiaZapasowa
            // 
            this.cbKopiaZapasowa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKopiaZapasowa.Location = new System.Drawing.Point(24, 50);
            this.cbKopiaZapasowa.Name = "cbKopiaZapasowa";
            this.cbKopiaZapasowa.Properties.Caption = "Stwórz kopię zapasową";
            this.cbKopiaZapasowa.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cbKopiaZapasowa.Size = new System.Drawing.Size(139, 19);
            this.cbKopiaZapasowa.StyleController = this.layoutControl1;
            this.cbKopiaZapasowa.TabIndex = 9;
            // 
            // btnZapiszRozmieszczenie
            // 
            this.btnZapiszRozmieszczenie.Image = ((System.Drawing.Image)(resources.GetObject("btnZapiszRozmieszczenie.Image")));
            this.btnZapiszRozmieszczenie.Location = new System.Drawing.Point(36, 600);
            this.btnZapiszRozmieszczenie.Name = "btnZapiszRozmieszczenie";
            this.btnZapiszRozmieszczenie.Size = new System.Drawing.Size(180, 38);
            this.btnZapiszRozmieszczenie.StyleController = this.layoutControl1;
            this.btnZapiszRozmieszczenie.TabIndex = 8;
            this.btnZapiszRozmieszczenie.Text = "Zapisz układ ikon na pulpicie";
            this.btnZapiszRozmieszczenie.Click += new System.EventHandler(this.btnZapiszRozmieszczenie_Click);
            // 
            // txtNazwaFolderuGlownego
            // 
            this.txtNazwaFolderuGlownego.Location = new System.Drawing.Point(146, 24);
            this.txtNazwaFolderuGlownego.Name = "txtNazwaFolderuGlownego";
            this.txtNazwaFolderuGlownego.Size = new System.Drawing.Size(156, 20);
            this.txtNazwaFolderuGlownego.StyleController = this.layoutControl1;
            this.txtNazwaFolderuGlownego.TabIndex = 6;
            // 
            // btnPrzywroc
            // 
            this.btnPrzywroc.Image = ((System.Drawing.Image)(resources.GetObject("btnPrzywroc.Image")));
            this.btnPrzywroc.Location = new System.Drawing.Point(220, 600);
            this.btnPrzywroc.Name = "btnPrzywroc";
            this.btnPrzywroc.Size = new System.Drawing.Size(144, 38);
            this.btnPrzywroc.StyleController = this.layoutControl1;
            this.btnPrzywroc.TabIndex = 5;
            this.btnPrzywroc.Text = "Przywróć pliki i układ";
            this.btnPrzywroc.ToolTip = "Jeśli układ nie powrócił do swojego pierwotnego stanu kliknij ponownie.";
            this.btnPrzywroc.Click += new System.EventHandler(this.btnPrzywroc_Click);
            // 
            // treeListFileExplorer
            // 
            this.treeListFileExplorer.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumnFoldery});
            this.treeListFileExplorer.Location = new System.Drawing.Point(397, 12);
            this.treeListFileExplorer.Name = "treeListFileExplorer";
            this.treeListFileExplorer.OptionsBehavior.Editable = false;
            this.treeListFileExplorer.OptionsBehavior.ReadOnly = true;
            this.treeListFileExplorer.SelectImageList = this.imageCollection1;
            this.treeListFileExplorer.Size = new System.Drawing.Size(278, 599);
            this.treeListFileExplorer.TabIndex = 4;
            this.treeListFileExplorer.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListFileExplorer_FocusedNodeChanged);
            this.treeListFileExplorer.VirtualTreeGetChildNodes += new DevExpress.XtraTreeList.VirtualTreeGetChildNodesEventHandler(this.treeListFileExplorer_VirtualTreeGetChildNodes);
            this.treeListFileExplorer.VirtualTreeGetCellValue += new DevExpress.XtraTreeList.VirtualTreeGetCellValueEventHandler(this.treeListFileExplorer_VirtualTreeGetCellValue);
            // 
            // treeListColumnFoldery
            // 
            this.treeListColumnFoldery.Caption = "Foldery";
            this.treeListColumnFoldery.FieldName = "treeListColumnFoldery";
            this.treeListColumnFoldery.MinWidth = 33;
            this.treeListColumnFoldery.Name = "treeListColumnFoldery";
            this.treeListColumnFoldery.Visible = true;
            this.treeListColumnFoldery.VisibleIndex = 0;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("open_16x16.png", "images/actions/open_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/open_16x16.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "open_16x16.png");
            this.imageCollection1.InsertGalleryImage("bofileattachment_16x16.png", "images/business%20objects/bofileattachment_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/bofileattachment_16x16.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "bofileattachment_16x16.png");
            this.imageCollection1.Images.SetKeyName(2, "broom.png");
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgRozszerzenia,
            this.layoutControlGroup2,
            this.layoutControlGroup4,
            this.splitterItem1,
            this.lcgKatalog});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(711, 674);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgRozszerzenia
            // 
            this.lcgRozszerzenia.Location = new System.Drawing.Point(0, 73);
            this.lcgRozszerzenia.Name = "lcgRozszerzenia";
            this.lcgRozszerzenia.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgRozszerzenia.Size = new System.Drawing.Size(380, 449);
            this.lcgRozszerzenia.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.lciSprzataj});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 522);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(380, 132);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciZapiszRozmieszczenie,
            this.lciPrzywroc});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 42);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(356, 66);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // lciZapiszRozmieszczenie
            // 
            this.lciZapiszRozmieszczenie.Control = this.btnZapiszRozmieszczenie;
            this.lciZapiszRozmieszczenie.Location = new System.Drawing.Point(0, 0);
            this.lciZapiszRozmieszczenie.Name = "lciZapiszRozmieszczenie";
            this.lciZapiszRozmieszczenie.Size = new System.Drawing.Size(184, 42);
            this.lciZapiszRozmieszczenie.TextSize = new System.Drawing.Size(0, 0);
            this.lciZapiszRozmieszczenie.TextVisible = false;
            // 
            // lciPrzywroc
            // 
            this.lciPrzywroc.Control = this.btnPrzywroc;
            this.lciPrzywroc.Location = new System.Drawing.Point(184, 0);
            this.lciPrzywroc.Name = "lciPrzywroc";
            this.lciPrzywroc.Size = new System.Drawing.Size(148, 42);
            this.lciPrzywroc.TextSize = new System.Drawing.Size(0, 0);
            this.lciPrzywroc.TextVisible = false;
            // 
            // lciSprzataj
            // 
            this.lciSprzataj.Control = this.btnSprzataj;
            this.lciSprzataj.Location = new System.Drawing.Point(0, 0);
            this.lciSprzataj.Name = "lciSprzataj";
            this.lciSprzataj.Size = new System.Drawing.Size(356, 42);
            this.lciSprzataj.TextSize = new System.Drawing.Size(0, 0);
            this.lciSprzataj.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciKopiaZapasowa,
            this.lciNazwaFolderuGlownego,
            this.lciOdswiez,
            this.emptySpaceItem1});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(380, 73);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // lciKopiaZapasowa
            // 
            this.lciKopiaZapasowa.Control = this.cbKopiaZapasowa;
            this.lciKopiaZapasowa.Location = new System.Drawing.Point(0, 26);
            this.lciKopiaZapasowa.Name = "lciKopiaZapasowa";
            this.lciKopiaZapasowa.Size = new System.Drawing.Size(143, 23);
            this.lciKopiaZapasowa.TextSize = new System.Drawing.Size(0, 0);
            this.lciKopiaZapasowa.TextVisible = false;
            // 
            // lciNazwaFolderuGlownego
            // 
            this.lciNazwaFolderuGlownego.Control = this.txtNazwaFolderuGlownego;
            this.lciNazwaFolderuGlownego.Location = new System.Drawing.Point(0, 0);
            this.lciNazwaFolderuGlownego.Name = "lciNazwaFolderuGlownego";
            this.lciNazwaFolderuGlownego.Size = new System.Drawing.Size(282, 26);
            this.lciNazwaFolderuGlownego.Text = "Nazwa folderu głównego";
            this.lciNazwaFolderuGlownego.TextSize = new System.Drawing.Size(119, 13);
            // 
            // lciOdswiez
            // 
            this.lciOdswiez.Control = this.btnOdswiez;
            this.lciOdswiez.Location = new System.Drawing.Point(282, 0);
            this.lciOdswiez.Name = "lciOdswiez";
            this.lciOdswiez.Size = new System.Drawing.Size(74, 26);
            this.lciOdswiez.TextSize = new System.Drawing.Size(0, 0);
            this.lciOdswiez.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(143, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(213, 23);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(380, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 654);
            // 
            // lcgKatalog
            // 
            this.lcgKatalog.ExpandButtonVisible = true;
            this.lcgKatalog.Expanded = false;
            this.lcgKatalog.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.FileExplorer});
            this.lcgKatalog.Location = new System.Drawing.Point(385, 0);
            this.lcgKatalog.Name = "lcgKatalog";
            this.lcgKatalog.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgKatalog.Size = new System.Drawing.Size(306, 654);
            this.lcgKatalog.Text = "Wybierz inną scieżkę";
            // 
            // FileExplorer
            // 
            this.FileExplorer.Control = this.treeListFileExplorer;
            this.FileExplorer.Location = new System.Drawing.Point(0, 0);
            this.FileExplorer.Name = "FileExplorer";
            this.FileExplorer.Size = new System.Drawing.Size(282, 603);
            this.FileExplorer.TextSize = new System.Drawing.Size(0, 0);
            this.FileExplorer.TextVisible = false;
            // 
            // ListView
            // 
            this.ListView.Location = new System.Drawing.Point(0, 0);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(0, 0);
            this.ListView.TextSize = new System.Drawing.Size(50, 20);
            // 
            // DesktopCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 674);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(727, 663);
            this.Name = "DesktopCleaner";
            this.Text = "Desktop cleaner beta v1.0";
            this.Load += new System.EventHandler(this.DesktopCleaner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbKopiaZapasowa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNazwaFolderuGlownego.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListFileExplorer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRozszerzenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciZapiszRozmieszczenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrzywroc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSprzataj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKopiaZapasowa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNazwaFolderuGlownego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOdswiez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgKatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileExplorer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgRozszerzenia;
       
      
        
      
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Lastmodified;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraLayout.LayoutControlItem ListView;
        private DevExpress.XtraTreeList.TreeList treeListFileExplorer;
        private DevExpress.XtraLayout.LayoutControlGroup lcgKatalog;
        private DevExpress.XtraLayout.LayoutControlItem FileExplorer;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnFoldery;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraEditors.SimpleButton btnPrzywroc;
        private DevExpress.XtraLayout.LayoutControlItem lciPrzywroc;
        private DevExpress.XtraEditors.TextEdit txtNazwaFolderuGlownego;
        private DevExpress.XtraLayout.LayoutControlItem lciNazwaFolderuGlownego;
        private DevExpress.XtraEditors.SimpleButton btnZapiszRozmieszczenie;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lciZapiszRozmieszczenie;
        private DevExpress.XtraEditors.CheckEdit cbKopiaZapasowa;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem lciKopiaZapasowa;
        private DevExpress.XtraEditors.SimpleButton btnOdswiez;
        private DevExpress.XtraLayout.LayoutControlItem lciOdswiez;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnSprzataj;
        private DevExpress.XtraLayout.LayoutControlItem lciSprzataj;

    }
}

