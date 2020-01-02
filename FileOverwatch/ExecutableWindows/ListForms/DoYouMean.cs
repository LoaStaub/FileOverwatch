using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DatabaseWindows;
using DatabaseWindows.DatabaseModels;

namespace ExecutableWindows.ListForms
{
    public partial class DoYouMean : Form
    {
        private static Group _group;
        private static Member _member;
        private static int _id;
        public DoYouMean(ref Group group, ref Member member, int id)
        {
            _group = group;
            _member = member;
            _id = id;
            InitializeComponent();
        }

        private void DoYouMean_Load(object sender, EventArgs e)
        {
            BtnMember.Text = _member.FirstName + " " + _member.LastName;
            BtnGroup.Text = _group.Name;
        }

        private async void BtnGroup_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            switch (_id)
            {
                case 1:
                    var phoneList = await db.PhoneNumbers.Where(d =>
                        !d.Deleted && d.GroupNode.Any(f => !f.Deleted && f.GroupId == _group.Id)).ToListAsync();
                    var phoneForm = new Phones(ref phoneList);
                    phoneForm.Show();
                    Close();
                    break;
                case 2:
                    var emailList = await db.Emails.Where(d =>
                        !d.Deleted && d.GroupNode.Any(f => !f.Deleted && f.GroupId == _group.Id)).ToListAsync();
                    var emailForm = new Emails(ref emailList);
                    emailForm.Show();
                    Close();
                    break;
                case 3:
                    var homepageList = await db.Homepages
                        .Where(d => !d.Deleted && d.GroupNode.Any(f => !f.Deleted && f.GroupId == _group.Id))
                        .ToListAsync();
                    var homepageForm = new Homepages(ref homepageList);
                    homepageForm.Show();
                    Close();
                    break;
            }
        }

        private async void BtnMember_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            switch (_id)
            {
                case 1:
                    var phoneList = await db.PhoneNumbers.Where(d =>
                        !d.Deleted && d.MemberNode.Any(f => !f.Deleted && f.MemberId == _group.Id)).ToListAsync();
                    var phoneForm = new Phones(ref phoneList);
                    phoneForm.Show();
                    Close();
                    break;
                case 2:
                    var emailList = await db.Emails.Where(d =>
                        !d.Deleted && d.MemberNode.Any(f => !f.Deleted && f.MemberId == _group.Id)).ToListAsync();
                    var emailForm = new Emails(ref emailList);
                    emailForm.Show();
                    Close();
                    break;
                case 3:
                    var homepageList = await db.Homepages
                        .Where(d => !d.Deleted && d.MemberNode.Any(f => !f.Deleted && f.MemberId == _group.Id))
                        .ToListAsync();
                    var homepageForm = new Homepages(ref homepageList);
                    homepageForm.Show();
                    Close();
                    break;
            }
        }
    }
}
