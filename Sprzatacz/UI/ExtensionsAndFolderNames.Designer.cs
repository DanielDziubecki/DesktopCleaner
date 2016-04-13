namespace SegragatorPulpitu.UI
{
    partial class ExtensionsAndFolderNames
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkExtensionName = new DevExpress.XtraEditors.CheckEdit();
            this.txtFolderName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkExtensionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolderName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkExtensionName
            // 
            this.checkExtensionName.Location = new System.Drawing.Point(3, 4);
            this.checkExtensionName.Name = "checkExtensionName";
            this.checkExtensionName.Properties.Appearance.Options.UseTextOptions = true;
            this.checkExtensionName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.checkExtensionName.Properties.Caption = "";
            this.checkExtensionName.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.checkExtensionName.Size = new System.Drawing.Size(59, 19);
            this.checkExtensionName.TabIndex = 0;
            this.checkExtensionName.CheckedChanged += new System.EventHandler(this.checkExtensionName_CheckedChanged);
            // 
            // txtFolderName
            // 
            this.txtFolderName.Enabled = false;
            this.txtFolderName.Location = new System.Drawing.Point(96, 3);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(247, 20);
            this.txtFolderName.TabIndex = 1;
            // 
            // ExtensionsAndFolderNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFolderName);
            this.Controls.Add(this.checkExtensionName);
            this.Name = "ExtensionsAndFolderNames";
            this.Size = new System.Drawing.Size(343, 50);
            ((System.ComponentModel.ISupportInitialize)(this.checkExtensionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolderName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit checkExtensionName;
        private DevExpress.XtraEditors.TextEdit txtFolderName;
    }
}
