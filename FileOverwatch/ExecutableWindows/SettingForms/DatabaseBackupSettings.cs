using System;
using System.Windows.Forms;

namespace ExecutableWindows.SettingForms
{
    public partial class DatabaseBackupSettings : Form
    {
        public DatabaseBackupSettings()
        {
            InitializeComponent();
        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            var fileDialog = new FolderBrowserDialog();
            fileDialog.ShowDialog();
            TbPath.Text = fileDialog.SelectedPath;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
