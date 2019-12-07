using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Database;
using Database.DatabaseModels;
using Executable.Classes;

namespace Executable
{
    public partial class CreateGroup : Form
    {
        private int _groupId;
        private Group _group = new Group();
        private Image _image;
        public CreateGroup(ref int groupId)
        {
            _groupId = groupId;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _group.Picture = ImageByteConverter.ImageToBytes(_image);
            _group.Description = TbDescription.Text;
            _group.Name = TbName.Text;
            _group.CreateDate = DateTime.UtcNow;
            var db = new DataBase();
            if (_groupId == 0)
            {
                db.Groups.Add(_group);
            }

            db.SaveChanges();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            db.Groups.Remove(_group);
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
            _image = image;
            _group.Picture = ImageByteConverter.ImageToBytes(image);
        }

        private void BtnDeletePicture_Click(object sender, EventArgs e)
        {
            _group.Picture = null;
            _image = null;
            PbImage.Image = null;
        }

        private void BtnOrganizations_Click(object sender, EventArgs e)
        {

        }

        private void BtnEmails_Click(object sender, EventArgs e)
        {

        }

        private void BtnPhones_Click(object sender, EventArgs e)
        {

        }

        private void BtnMembers_Click(object sender, EventArgs e)
        {

        }

        private void CreateGroup_Load(object sender, EventArgs e)
        {
            if (_groupId == 0)
            {
                BtnDelete.Visible = false;
                return;
            }

            var db = new DataBase();
            _group = db.Groups.FirstOrDefault(group => group.Id == _groupId);
            FillElements();
        }

        private void FillElements()
        {
            TbName.Text = _group.Name;
            TbDescription.Text = _group.Description;
            PbImage.Image = ImageByteConverter.BytesToImage(_group.Picture);
        }
    }
}
