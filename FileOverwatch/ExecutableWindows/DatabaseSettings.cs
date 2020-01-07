using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExecutableWindows.Properties;

namespace ExecutableWindows
{
    public partial class DatabaseSettings : Form
    {
        public DatabaseSettings()
        {
            InitializeComponent();
        }

        private void BtnDirectory_Click(object sender, EventArgs e)
        {
            var openFolderDialog = new FolderBrowserDialog();
            openFolderDialog.ShowDialog();
            TbPath.Text = openFolderDialog.SelectedPath;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            var origin = Settings.Default.PathToDatabase;
            File.Copy(origin, TbPath.Text + "/FileOverwatch.db");
            if (CheckRemap.Checked)
            {
                Settings.Default.PathToDatabase = TbPath.Text + "/FileOverwatch.db";
                Settings.Default.Save();
            }
        }
    }
}
