﻿using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DatabaseWindows;
using DatabaseWindows.DatabaseModels;
using DatabaseWindows.DatabaseModels.LinkingTables;
using Executable.Classes;

namespace ExecutableWindows
{
    public partial class CreateGroup : Form
    {
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
            _group.CreateDate = DateTime.UtcNow;
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
            }

            await db.SaveChangesAsync();
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
            _group.Picture = ImageByteConverter.ImageToBytes(image);
        }

        private void BtnDeletePicture_Click(object sender, EventArgs e)
        {
            _group.Picture = null;
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

        private Group _group = new Group();
        private void CreateGroup_Load(object sender, EventArgs e)
        {
            var db = new DataBase();
            var organizations = db.Organizations.Where(orga => !orga.Deleted).ToList();
            CbOrganizations.DataSource = organizations;
            CbOrganizations.DisplayMember = "Name";
            CbOrganizations.ValueMember = "Id";
            if (_group.Id == 0)
            {
                BtnDelete.Visible = false;
                return;
            }

            _group = db.Groups.FirstOrDefault(group => group.Id == _group.Id);
            FillElements();
        }

        private void FillElements()
        {
            var selected = false;
            var counter = 0;
            foreach (var organization in _group.OrganizationNode)
            {
                if(!organization.Organization.Deleted)
                {
                    if (!selected)
                    {
                        CbOrganizations.SelectedItem = organization.Organization.Name;
                    }
                    selected = true;
                    counter++;
                }
            }

            if (counter != 0)
            {
                counter--;
            }
            LblCounter.Text = $@"{counter} more";
            TbName.Text = _group.Name;
            TbDescription.Text = _group.Description;
            PbImage.Image = ImageByteConverter.BytesToImage(_group.Picture);
        }
    }
}
