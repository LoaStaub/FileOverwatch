using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseWindows;
using DatabaseWindows.DatabaseModels;

namespace ExecutableWindows.ListForms
{
    public partial class Emails : Form
    {
        private static List<Email> _emails;
        private static Email _email;
        private static bool _isOpenedByEditor;
        public Emails(ref List<Email> emails, bool isOpenedByEditor)
        {
            _emails = emails;
            _isOpenedByEditor = isOpenedByEditor;
            InitializeComponent();
            TvEmails.ShowGroups = false;
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ContainsEmail())
            {
                var email = _emails.FirstOrDefault(d => d.Id == _email.Id);
                if (email != null)
                {
                    email.Description = TbDescription.Text;
                    email.Mail = TbDescription.Text;

                    TvEmails.UpdateObject(email);
                    
                    if (_isOpenedByEditor)
                    {
                        return;
                    }
                    var db = new DataBase();
                    db.Entry(email).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                }
            }
        }

        private async void BtnNew_Click(object sender, EventArgs e)
        {
            if (ContainsEmail())
            {
                var email = new Email
                {
                    Deleted = false,
                    CreateDate = DateTime.Now,
                    Description = TbDescription.Text,
                    Mail = TbEmail.Text
                };
                _emails.Add(email);
                TvEmails.AddObject(email);
                if (_isOpenedByEditor)
                {
                    return;
                }

                var db = new DataBase();
                db.Emails.Add(email);
                await db.SaveChangesAsync();
            }

        }

        private bool ContainsEmail()
        {
            bool containsMail = true;
            if (!TbEmail.Text.Contains("@"))
            {
                containsMail = false;
                MessageBox.Show("Your E-Mail Adress doesn't contain an @");
            }

            if (!TbEmail.Text.Contains("."))
            {
                containsMail = false;
                MessageBox.Show("");
            }

            return containsMail;
        }

        private void TvEmails_SelectionChanged(object sender, EventArgs e)
        {
            _email = (Email) TvEmails.SelectedObject;
            TbEmail.Text = _email.Mail;
        }

        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            var mailto = "mailto:" + _email.Mail;
            Process.Start(mailto);
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            var email = _emails.FirstOrDefault(d => d.Id == _email.Id);
            if (email != null)
            {
                email.Deleted = true;
                TvEmails.DisableObject(email);
            }
            if (_isOpenedByEditor)
            {
                return;
            }

            var db = new DataBase();
            db.Entry(email).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
