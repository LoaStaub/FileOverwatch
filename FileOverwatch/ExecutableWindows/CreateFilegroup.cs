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
    public partial class CreateFilegroup : Form
    {
        private FileOverhead _fileOverhead;
        public CreateFilegroup(ref FileOverhead fileOverhead)
        {
            _fileOverhead = fileOverhead;
            InitializeComponent();
        }

        private void BtnAbort_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            _fileOverhead.Deleted = true;
            db.Entry(_fileOverhead).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            _fileOverhead.Deleted = false;
            _fileOverhead.Description = TbDescription.Text;
            _fileOverhead.Name = TbName.Text;
            if (_fileOverhead.Id == 0)
            {
                _fileOverhead.CreateDate = DateTime.Now;
                db.FileOverheads.Add(_fileOverhead);
                var member = (MemberForCombobox) CbMembers.SelectedItem;
                var fileHeadToMember = new OverheadToMember
                {
                    CreateDate = DateTime.Now,
                    Deleted = false,
                    FileOverheadId = _fileOverhead.Id,
                    MemberId = member.Id
                };
                db.OverheadToMemberNode.Add(fileHeadToMember);
            }
            else
            {
                db.Entry(_fileOverhead).State = EntityState.Modified;
            }

            await db.SaveChangesAsync();
        }

        private async void CreateFilegroup_Load(object sender, EventArgs e)
        {
            var db = new DataBase();
            var orgas = await db.Organizations.Where(d => !d.Deleted).ToListAsync();
            CbOrganizations.DataSource = orgas;
            CbOrganizations.DisplayMember = "Name";
            CbOrganizations.ValueMember = "Id";
        }

        private async void CbOrganizations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var orga = (Organization) CbOrganizations.SelectedItem;
            var db = new DataBase();
            var groups = await db.Groups.Where(d =>
                !d.Deleted && d.OrganizationNode.Any(f => !f.Deleted && f.Organization.Id == orga.Id)).ToListAsync();
            CbGroups.DataSource = groups;
            CbGroups.DisplayMember = "Name";
            CbGroups.ValueMember = "Id";
        }

        private async void CbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new DataBase();
            var members = await db.Members
                .Where(d => !d.Deleted && d.GroupNode.Any(f => !f.Deleted 
                                                               && f.GroupId == ((Group)CbGroups.SelectedItem).Id))
                .ToListAsync();
            var memberForCbList = members.Select(member => 
                new MemberForCombobox { Id = member.Id, Member = member, 
                    Name = $"{member.FirstName} {member.LastName}" }).ToList();

            CbMembers.DataSource = memberForCbList;
            CbMembers.DisplayMember = "Name";
            CbMembers.ValueMember = "Id";
        }
    }
}
