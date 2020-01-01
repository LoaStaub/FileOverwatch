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

namespace FileAdding
{
    public partial class FileAdder : Form
    {
        private static string[] _args;
        public FileAdder(string[] args)
        {
            _args = args;
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
            if (_args.Length == 0)
            {
                var db2 = new DataBase();
                var organizations2 = await db2.Organizations.Where(d => !d.Deleted).ToListAsync();
                CbOrganizations.DataSource = organizations2;
                CbOrganizations.DisplayMember = "Name";
                CbOrganizations.ValueMember = "Id";
                return;
            }
            var directory = _args[0];
            LblFilePath.Text = directory;
            var db = new DataBase();
            if (await db.LinkedFiles.AnyAsync(d => d.Directory == directory) && await db.ExcelFiles.AnyAsync(d => d.Directory == directory) && await db.WordFiles.AnyAsync(d => d.Directory == directory))
            {
                var option = MessageBox.Show("This File got linked, do you want to link it to another Entry?", "File already linked",
                    MessageBoxButtons.OKCancel);
                if (option == DialogResult.OK)
                {
                    return;
                }

                Close();
            }

            var organizations = await db.Organizations.Where(d => !d.Deleted).ToListAsync();
            CbOrganizations.DataSource = organizations;
            CbOrganizations.DisplayMember = "Name";
            CbOrganizations.ValueMember = "Id";
        }
    }
}
