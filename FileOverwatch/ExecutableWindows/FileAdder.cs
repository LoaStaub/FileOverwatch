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
using ExecutableWindows.Models;

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

        private async void CbOrganizations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new DataBase();
            var groups = await db.Groups.Where(d =>
                !d.Deleted &&
                d.OrganizationNode.Any(f => !f.Deleted && f.OrganizationId == ((Organization)CbOrganizations.SelectedItem).Id)).ToListAsync();

            CbGroups.DataSource = groups;
            CbGroups.DisplayMember = "Name";
            CbGroups.ValueMember = "Id";
        }

        private async void CbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new DataBase();
            var members = await db.Members
                .Where(d => !d.Deleted && d.GroupNode.Any(f => !f.Deleted && f.GroupId == ((Group) CbGroups.SelectedItem).Id))
                .ToListAsync();
            var memberForCbList = members.Select(member => new MemberForCombobox {Id = member.Id, Member = member, Name = $"{member.FirstName} {member.LastName}"}).ToList();

            CbMember.DataSource = memberForCbList;
            CbMember.DisplayMember = "Name";
            CbMember.ValueMember = "Id";
        }

        private async void CbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void BtnNewFilegroup_Click(object sender, EventArgs e)
        {
            var fileHead = new FileOverhead();
            var createFileGroup = new CreateFilegroup(ref fileHead, false);
            createFileGroup.ShowDialog();
        }
    }
}
