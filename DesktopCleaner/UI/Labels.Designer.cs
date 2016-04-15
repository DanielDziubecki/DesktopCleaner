namespace SegragatorPulpitu.UI
{
    partial class Labels
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
            this.lbiExtensions = new DevExpress.XtraEditors.LabelControl();
            this.lblFolderName = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lbiExtensions
            // 
            this.lbiExtensions.Location = new System.Drawing.Point(3, 4);
            this.lbiExtensions.Name = "lbiExtensions";
            this.lbiExtensions.Size = new System.Drawing.Size(63, 13);
            this.lbiExtensions.TabIndex = 0;
            this.lbiExtensions.Text = "Rozszerzenia";
            // 
            // lblFolderName
            // 
            this.lblFolderName.Location = new System.Drawing.Point(96, 3);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(69, 13);
            this.lblFolderName.TabIndex = 1;
            this.lblFolderName.Text = "Nazwa folderu";
            // 
            // Labels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFolderName);
            this.Controls.Add(this.lbiExtensions);
            this.Name = "Labels";
            this.Size = new System.Drawing.Size(343, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbiExtensions;
        private DevExpress.XtraEditors.LabelControl lblFolderName;
    }
}
