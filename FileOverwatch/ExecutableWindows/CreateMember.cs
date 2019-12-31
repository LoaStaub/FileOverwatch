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
using DatabaseWindows.DatabaseModels.LinkingTables;
using Executable.Classes;

namespace ExecutableWindows
{
    public partial class CreateMember : Form
    {
        private int _memberId;
        private Member _member = new Member();
        private Image _image;
        public CreateMember(ref int memberId)
        {
            _memberId = memberId;
            InitializeComponent();
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
            _image = image;
            _member.Picture = ImageByteConverter.ImageToBytes(image);
        }

        private void BtnDeletePicture_Click(object sender, EventArgs e)
        {
            _member.Picture = null;
            _image = null;
            PbImage.Image = null;
        }

        private void BtnPhones_Click(object sender, EventArgs e)
        {

        }

        private void BtnHomepages_Click(object sender, EventArgs e)
        {

        }

        private void BtnGroups_Click(object sender, EventArgs e)
        {

        }

        private void BtnEmails_Click(object sender, EventArgs e)
        {

        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            _member.City = TbCity.Text;
            _member.Country = TbCountry.Text;
            _member.Description = TbDescription.Text;
            _member.HouseNumber = TbHouseNumber.Text;
            _member.FirstName = TbFirstName.Text;
            _member.LastName = TbLastname.Text;
            _member.State = TbState.Text;
            _member.Street = TbStreet.Text;
            _member.Gender = TbGender.Text;
            _member.ZipCode = TbZipCode.Text;
            _member.Birthdate = DtpBirthdate.Value;
            _member.CreateDate = DateTime.UtcNow;
            var db = new DataBase();
            if (_memberId == 0)
            {
                var node = new GroupToMember
                {
                    CreateDate = DateTime.Now,
                    Deleted = false,
                    GroupId = ((Group) CbGroups.SelectedItem).Id,
                    Member = _member
                };
                db.Members.Add(_member);
                db.GroupToMemberNode.Add(node);
            }

            await db.SaveChangesAsync();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            db.Members.Remove(_member);
            db.SaveChanges();
            Close();
        }

        private void BtnAbort_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void CreateMember_Load(object sender, EventArgs e)
        {
            var db = new DataBase();
            var organizations = await db.Organizations.Where(d => !d.Deleted).ToListAsync();
            CbOrganizations.DataSource = organizations;
            CbOrganizations.DisplayMember = "Name";
            CbOrganizations.ValueMember = "Id";

            if (_memberId == 0)
            {
                BtnDelete.Visible = false;
                return;
            }

            
            _member = db.Members.FirstOrDefault(member => member.Id == _memberId);
            FillElements();
        }

        private void FillElements()
        {
            TbCity.Text = _member.City;
            TbCountry.Text = _member.Country;
            TbDescription.Text = _member.Description;
            TbHouseNumber.Text = _member.HouseNumber;
            TbFirstName.Text = _member.FirstName;
            TbLastname.Text = _member.LastName;
            TbState.Text = _member.State;
            TbStreet.Text = _member.Street;
            TbGender.Text = _member.Gender;
            TbZipCode.Text = _member.ZipCode;
            DtpBirthdate.Value = _member.Birthdate;
            PbImage.Image = ImageByteConverter.BytesToImage(_member.Picture);
        }

        private async void CbOrganizations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new DataBase();
            var groups = await db.Groups.Where(d =>
                !d.Deleted &&
                d.OrganizationNode.Any(f => !f.Deleted && f.OrganizationId == ((Organization) CbOrganizations.SelectedItem).Id)).ToListAsync();
            if (groups.Count != 0)
            {
                CbGroups.DataSource = groups;
                CbGroups.DisplayMember = "Name";
                CbGroups.ValueMember = "Id";
            }
        }
    }
}
