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
using Database;
using Database.DatabaseModels;
using Executable.Classes;

namespace Executable
{
    public partial class CreateOrganization : Form
    {
        private int _organizationId;
        private Organization _organization = new Organization();
        public CreateOrganization(ref int organizationId)
        {
            _organizationId = organizationId;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
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
            _organization.Picture = ImageByteConverter.ImageToBytes(PbImage.Image);
        }

        private void CreateOrganization_Load(object sender, EventArgs e)
        {
            if (_organizationId == 0)
            {
                BtnDelete.Visible = false;
                return;
            }

            var db = new DataBase();
            _organization = db.Organizations.FirstOrDefault(orga => orga.Id == _organizationId);
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            db.Remove(_organization);
            db.SaveChanges();
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
    }
}
