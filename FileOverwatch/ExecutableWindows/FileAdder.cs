using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DatabaseWindows;
using DatabaseWindows.DatabaseModels;
using DatabaseWindows.DatabaseModels.LinkingTables;
using ExecutableWindows.Models;

namespace ExecutableWindows
{
    public partial class FileAdder : Form
    {
        private LinkedFile _linkedFile;
        public FileAdder(ref LinkedFile linkedFile)
        {
            _linkedFile = linkedFile;
            InitializeComponent();
        }

        private async void BtnAddFile_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            if (_linkedFile.Id != 0)
            {
                _linkedFile.Description = TbDescription.Text;
                _linkedFile.Directory = TbFilepath.Text;
                _linkedFile.FileName = TbFilename.Text;
                db.Entry(_linkedFile).State = EntityState.Modified;
                var containsConnection = db.FileToOverheadNode.Any(d =>
                    !d.Deleted && d.FileOverheadId == ((FileOverhead) CbFileOverhead.SelectedItem).Id &&
                    d.LinkedFileId == _linkedFile.Id);
                if (!containsConnection)
                {
                    var fileToOverheadNode = new FileToOverhead
                    {
                        Deleted = false,
                        CreateDate = DateTime.Now,
                        FileOverheadId = ((FileOverhead)CbFileOverhead.SelectedItem).Id,
                        LinkedFileId = _linkedFile.Id
                    };
                    db.FileToOverheadNode.Add(fileToOverheadNode);
                }
                await db.SaveChangesAsync();
                return;
            }
            var fileOverhead = (FileOverhead) CbFileOverhead.SelectedItem;
            var file = new LinkedFile
            {
                CreateDate = DateTime.Now,
                Deleted = false,
                Description = TbDescription.Text,
                Directory = TbFilepath.Text,
                FileName = TbFilename.Text,
                LastAccess = DateTime.Now
            };
            
            db.LinkedFiles.Add(file);
            var fileToOverhead = new FileToOverhead
            {
                Deleted = false,
                CreateDate = DateTime.Now,
                FileOverheadId = fileOverhead.Id,
                LinkedFileId = file.Id
            };
            db.FileToOverheadNode.Add(fileToOverhead);
            await db.SaveChangesAsync();
        }

        private async void CbOrganizations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new DataBase();
            var groups = await db.Groups.Where(d =>
                !d.Deleted &&
                d.OrganizationNode.Any(f => !f.Deleted && f.OrganizationId == 
                                            ((Organization)CbOrganizations.SelectedItem).Id))
                                            .ToListAsync();

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
            var db = new DataBase();
            var fileOverheads = await db.FileOverheads.Where(d =>
                !d.Deleted && d.MemberNode.Any(f =>
                    !f.Deleted && f.MemberId == ((MemberForCombobox) CbMember.SelectedItem).Id)).ToListAsync();
            CbFileOverhead.DataSource = fileOverheads;
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
            TbFilepath.Text = openFileDialog.FileName;
        }

        private void BtnNewFilegroup_Click(object sender, EventArgs e)
        {
            var fileHead = new FileOverhead();
            var createFileGroup = new CreateFilegroup(ref fileHead);
            createFileGroup.ShowDialog();
        }
    }
}
