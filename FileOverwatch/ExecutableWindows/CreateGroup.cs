using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DatabaseWindows;
using DatabaseWindows.DatabaseModels;
using DatabaseWindows.DatabaseModels.LinkingTables;
using ExecutableWindows.Classes;
using ExecutableWindows.ListForms;

namespace ExecutableWindows
{
    public partial class CreateGroup : Form
    {
        private Group _group;
        public CreateGroup(ref Group group)
        {
            _group = group;
            InitializeComponent();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            _group.Picture = ImageByteConverter.ImageToBytes(PbImage.Image);
            _group.Description = TbDescription.Text;
            _group.Name = TbName.Text;
            _group.CreateDate = DateTime.Now;
            var db = new DataBase();
            if (_group.Id == 0)
            {
                db.Groups.Add(_group);
                var node = new GroupToOrganization
                {
                    CreateDate = DateTime.Now,
                    Group = _group,
                    Deleted = false,
                    OrganizationId = ((Organization)CbOrganizations.SelectedItem).Id
                };
                db.GroupToOrganizationNode.Add(node);
            }
            else
            {
                db.Entry(_group).State = EntityState.Modified;
                var oldGroupNode =
                    await db.GroupToOrganizationNode
                        .FirstOrDefaultAsync(d => !d.Deleted &&
                                                  d.GroupId == _group.Id &&
                                                  d.OrganizationId == ((Organization)CbOrganizations.SelectedItem).Id);
                if (oldGroupNode != null)
                {
                    oldGroupNode.Deleted = CheckOldLink.Checked;
                    var newGroupNode = new GroupToOrganization
                    {
                        CreateDate = DateTime.Now,
                        GroupId = _group.Id,
                        Deleted = false,
                        OrganizationId = ((Organization)CbOrganizations.SelectedItem).Id
                    }; 
                    db.GroupToOrganizationNode.Add(newGroupNode);
                }
            }
            if (_gotEmails)
            {
                foreach (var email in _emails)
                {
                    if (email.GroupNode.Any(d => !d.Deleted && d.GroupId == _group.Id)) continue;
                    var emailToGroupNode = new EmailToGroup
                    {
                        EmailId = email.Id,
                        CreateDate = DateTime.Now,
                        Deleted = false,
                        GroupId = _group.Id
                    };
                    db.EmailToGroupNode.Add(emailToGroupNode);
                }
                db.Emails.AddRange(_emails);
            }

            if (_gotHomepage)
            {
                foreach (var homepage in _homepages)
                {
                    if (homepage.GroupNode.Any(d => !d.Deleted && d.GroupId == _group.Id)) continue;
                    var homepageToGroupNode = new HomepageToGroup
                    {
                        HomepageId = homepage.Id,
                        CreateDate = DateTime.Now,
                        Deleted = false,
                        GroupId = _group.Id
                    };
                    db.HomepageToGroupNode.Add(homepageToGroupNode);
                }
                db.Homepages.AddRange(_homepages);
            }

            if (_gotPhone)
            {
                foreach (var number in _phoneNumbers)
                {
                    if (number.GroupNode.Any(d => !d.Deleted && d.GroupId == _group.Id)) continue;
                    var phoneToGroupNode = new PhoneToGroup
                    {
                        PhoneNumberId = number.Id,
                        CreateDate = DateTime.Now,
                        Deleted = false,
                        GroupId = _group.Id
                    };
                    db.PhoneToGroupNode.Add(phoneToGroupNode);
                }
                db.PhoneNumbers.AddRange(_phoneNumbers);
            }

            await db.SaveChangesAsync();
            Close();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            _group.Deleted = true;
            db.Entry(_group).State = EntityState.Modified;
            await db.SaveChangesAsync();
            Close();
        }

        private void BtnAbort_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnUploadPicture_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = $@"C:\Users\{Environment.UserName}\Bilder",
                Filter = @"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",
            };
            try
            {
                openFileDialog.ShowDialog();
            }
            catch
            {
                openFileDialog.InitialDirectory = "";
                openFileDialog.ShowDialog();
            }
            var pathToPic = openFileDialog.FileName;
            var image = Image.FromFile(pathToPic);
            PbImage.Image = image;
            _group.Picture = ImageByteConverter.ImageToBytes(image);
        }

        private void BtnDeletePicture_Click(object sender, EventArgs e)
        {
            _group.Picture = null;
            PbImage.Image = null;
        }

        private static bool _gotEmails;
        private static List<Email> _emails;
        private async void BtnEmails_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            var emails = new List<Email>();
            if (_group.Id != 0)
            {
                emails = await db.Emails.Where(d =>
                    !d.Deleted && d.GroupNode.Any(f => !f.Deleted && f.GroupId == _group.Id)).ToListAsync();
            }

            var emailForm = new Emails(ref emails,0, 0, true);
            emailForm.ShowDialog();
            _gotEmails = true;
            _emails = emails;
        }

        private static bool _gotPhone;
        private static List<PhoneNumber> _phoneNumbers;
        private async void BtnPhones_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            var phoneNumbers = new List<PhoneNumber>();
            if (_group.Id != 0)
            {
                phoneNumbers = await db.PhoneNumbers.Where(d =>
                    !d.Deleted && d.GroupNode.Any(f => !f.Deleted && f.GroupId == _group.Id)).ToListAsync();
            }

            var phoneForm = new Phones(ref phoneNumbers, 0, 0, true);
            phoneForm.ShowDialog();
            _gotPhone = true;
            _phoneNumbers = phoneNumbers;
        }

        private async void CreateGroup_Load(object sender, EventArgs e)
        {
            var db = new DataBase();
            var organizations = await db.Organizations.Where(orga => !orga.Deleted).ToListAsync();
            CbOrganizations.DataSource = organizations;
            CbOrganizations.DisplayMember = "Name";
            CbOrganizations.ValueMember = "Id";
            if (_group.Id == 0)
            {
                BtnDelete.Visible = false;
                CheckOldLink.Visible = false;
                return;
            }

            var usedOrganizations = await db.Organizations
                .Where(d => !d.Deleted && d.GroupNode.Any(f => !f.Deleted && f.GroupId == _group.Id)).ToListAsync();
            CbOrganizations.SelectedItem = usedOrganizations[0];
            LblCounter.Text = $@"{usedOrganizations.Count - 1} more";

            FillElements();
        }

        private void FillElements()
        {
            TbName.Text = _group.Name;
            TbDescription.Text = _group.Description;
            PbImage.Image = ImageByteConverter.BytesToImage(_group.Picture);
        }

        private static bool _gotHomepage;
        private static List<Homepage> _homepages;
        private async void BtnHomepage_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            var homepages = new List<Homepage>();
            if (_group.Id != 0)
            {
                homepages = await db.Homepages.Where(d =>
                    !d.Deleted && d.GroupNode.Any(f => !f.Deleted && f.GroupId == _group.Id)).ToListAsync();
            }

            var homepageForm = new Homepages(ref homepages, 0, 0, true);
            homepageForm.ShowDialog();
            _gotHomepage = true;
            _homepages = homepages;
        }
    }
}
