using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseWindows;
using DatabaseWindows.DatabaseModels;

namespace ExecutableWindows
{
    public partial class FileAdder : Form
    {
        private static string _pathToFile;
        public FileAdder()
        {
            InitializeComponent();
        }

        private void BtnAddFile_Click(object sender, EventArgs e)
        {
        }

        private void CbOrganizations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var groupNode = ((Organization) CbOrganizations.SelectedItem).GroupNode;
            var groups = groupNode.Where(node => !node.Deleted).Select(node => node.Group).ToList();

            CbGroups.DataSource = groups;
            CbGroups.DisplayMember = "Name";
            CbGroups.ValueMember = "Id";
        }

        private async void CbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            var memberNode = ((Group) CbGroups.SelectedItem).MemberNode;
            var members = memberNode.Where(node => !node.Deleted).Select(node => node.Group).ToList();

            CbGroups.DataSource = members;
            CbGroups.DisplayMember = "Name";
            CbGroups.ValueMember = "Id";

            var db = new DataBase();
            var fileOverhead = await db.FileOverheads.Where(d => !d.Deleted && d.GroupNode.Any(f => f.Group == (Group) CbGroups.SelectedItem)).ToListAsync();
            CbFileOverhead.DataSource = fileOverhead;
            CbFileOverhead.DisplayMember = "Name";
            CbFileOverhead.ValueMember = "Id";
        }

        private async void CbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new DataBase();
            var fileOverhead = await db.FileOverheads.Where(d => !d.Deleted && d.EmployeeNode.Any(f => f.Member == (Member) CbMember.SelectedItem)).ToListAsync();
            CbFileOverhead.DataSource = fileOverhead;
            CbFileOverhead.DisplayMember = "Name";
            CbFileOverhead.ValueMember = "Id";
        }

        private async void FileAdder_Load(object sender, EventArgs e)
        {
            var db = new DataBase();
            var organizations = await db.Organizations.Where(d => !d.Deleted).ToListAsync();
            CbOrganizations.DataSource = organizations;
            CbOrganizations.DisplayMember = "Name";
            CbOrganizations.ValueMember = "Id";
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            _pathToFile = openFileDialog.FileName;
            TbFilepath.Text = _pathToFile;
        }

        private void TbFilepath_TextChanged(object sender, EventArgs e)
        {
            _pathToFile = TbFilepath.Text;
        }
    }
}
