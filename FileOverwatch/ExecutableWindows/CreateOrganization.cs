using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DatabaseWindows;
using DatabaseWindows.DatabaseModels;
using DatabaseWindows.DatabaseModels.LinkingTables;
using Executable.Classes;
using ExecutableWindows.ListForms;

namespace ExecutableWindows
{
    public partial class CreateOrganization : Form
    {
        public CreateOrganization(ref Organization organization)
        {
            _organization = organization;
            InitializeComponent();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            _organization.City = TbCity.Text;
            _organization.Country = TbCountry.Text;
            _organization.Description = TbDescription.Text;
            _organization.HouseNumber = TbHouseNumber.Text;
            _organization.Name = TbName.Text;
            _organization.State = TbState.Text;
            _organization.Street = TbStreet.Text;
            _organization.Type = TbType.Text;
            _organization.PostalCode = TbZipCode.Text;
            _organization.Founded = DtpFounded.Value;
            var db = new DataBase();
            if (_organization.Id == 0)
            {
                _organization.CreateDate = DateTime.UtcNow;
                db.Organizations.Add(_organization);
            }
            else
            {
                db.Entry(_organization).State = EntityState.Modified;
            }

            if (_gotEmails)
            {
                foreach (var email in _emails)
                {
                    var emailToOrganizationNode = new EmailToOrganization
                    {
                        EmailId = email.Id,
                        CreateDate = DateTime.Now,
                        Deleted = false,
                        OrganizationId = _organization.Id
                    };
                    db.EmailToOrganizationNode.Add(emailToOrganizationNode);
                }
                db.Emails.AddRange(_emails);
            }

            if (_gotHomepage)
            {
                foreach (var homepage in _homepages)
                {
                    var homepageToOrganizationNode = new HomepageToOrganization
                    {
                        HomepageId = homepage.Id,
                        CreateDate = DateTime.Now,
                        Deleted = false,
                        OrganizationId = _organization.Id
                    };
                    db.HomepageToOrganizationNode.Add(homepageToOrganizationNode);
                }
                db.Homepages.AddRange(_homepages);
            }

            if (_gotPhone)
            {
                foreach (var number in _phoneNumbers)
                {
                    var phoneToOrganizationNode = new PhoneToOrganization
                    {
                        PhoneNumberId = number.Id,
                        CreateDate = DateTime.Now,
                        Deleted = false,
                        OrganizationId = _organization.Id
                    };
                    db.PhoneToOrganizationNode.Add(phoneToOrganizationNode);
                }
                db.PhoneNumbers.AddRange(_phoneNumbers);
            }
            await db.SaveChangesAsync();
        }

        private Organization _organization;
        private async void CreateOrganization_Load(object sender, EventArgs e)
        {
            if (_organization.Id == 0)
            {
                BtnDelete.Visible = false;
                return;
            }

            FillElements();
        }

        private void FillElements()
        {
            TbCity.Text = _organization.City;
            TbCountry.Text = _organization.Country;
            TbDescription.Text = _organization.Description;
            TbHouseNumber.Text = _organization.HouseNumber;
            TbName.Text = _organization.Name;
            TbState.Text = _organization.State;
            TbStreet.Text = _organization.Street;
            TbType.Text = _organization.Type;
            TbZipCode.Text = _organization.PostalCode;
            DtpFounded.Value = _organization.Founded;
            PbImage.Image = ImageByteConverter.BytesToImage(_organization.Picture);
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            _organization.Deleted = true;
            db.Entry(_organization).State = EntityState.Modified;
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
            _organization.Picture = ImageByteConverter.ImageToBytes(image);
        }

        private void BtnDeletePicture_Click(object sender, EventArgs e)
        {
            _organization.Picture = null;
            PbImage.Image = null;
        }

        private static bool _gotEmails;
        private static List<Email> _emails;
        private async void BtnEmails_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            var emails = new List<Email>();
            if (_organization.Id != 0)
            {
                emails = await db.Emails.Where(d =>
                    !d.Deleted && d.OrganizationNode.Any(f => !f.Deleted && f.OrganizationId == _organization.Id)).ToListAsync();
            }

            var emailForm = new Emails(ref emails, 0, 0, true);
            emailForm.ShowDialog();
            _gotEmails = true;
            _emails = emails;
        }

        private void BtnGroups_Click(object sender, EventArgs e)
        {

        }

        private static bool _gotHomepage;
        private static List<Homepage> _homepages;
        private async void BtnHomepages_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            var homepages = new List<Homepage>();
            if (_organization.Id != 0)
            {
                homepages = await db.Homepages.Where(d =>
                    !d.Deleted && d.OrganizationNode.Any(f => !f.Deleted && f.OrganizationId == _organization.Id)).ToListAsync();
            }

            var homepageForm = new Homepages(ref homepages, 0, 0, true);
            homepageForm.ShowDialog();
            _gotHomepage = true;
            _homepages = homepages;
        }

        private void BtnMembers_Click(object sender, EventArgs e)
        {

        }

        private static bool _gotPhone;
        private static List<PhoneNumber> _phoneNumbers;
        private async void BtnPhones_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            var phoneNumbers = new List<PhoneNumber>();
            if (_organization.Id != 0)
            {
                phoneNumbers = await db.PhoneNumbers.Where(d =>
                    !d.Deleted && d.OrganizationNode.Any(f => !f.Deleted && f.OrganizationId == _organization.Id)).ToListAsync();
            }

            var phoneForm = new Phones(ref phoneNumbers, 0, 0, true);
            phoneForm.ShowDialog();
            _gotPhone = true;
            _phoneNumbers = phoneNumbers;
        }
    }
}
