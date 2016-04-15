using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SegragatorPulpitu.UI
{
    public partial class ExtensionsAndFolderNames : UserControl
    {
        public ExtensionsAndFolderNames()
        {
            InitializeComponent();
        }

        public ExtensionsAndFolderNames(string checkEditText)
        {
            InitializeComponent();
            checkExtensionName.Text = checkEditText;
            checkExtensionName.Name = checkEditText;
        }
        private void checkExtensionName_CheckedChanged(object sender, EventArgs e)
        {
            var checkedCheckbox = sender as CheckEdit;
            if (checkedCheckbox != null && checkedCheckbox.Checked)
            {
                txtFolderName.Enabled = true;
            }
            else
            {
                txtFolderName.Enabled = false;
            }
        }
    }
}
