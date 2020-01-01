using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseWindows;
using DatabaseWindows.DatabaseModels;

namespace ExecutableWindows
{
    public partial class Emails : Form
    {
        private static Email _email;
        public Emails()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ContainsEmail())
            {
                var email = new Email
                {
                    Deleted = false,
                    CreateDate = DateTime.Now,
                    Description = TbDescription.Text,
                    Mail = TbDescription.Text
                };
                var db = new DataBase();
                db.Emails.Add(email);
                //todo: Erstelle ne E-Mail Node (auch für die anderen Sachen)) und update die ID zu den Membern irgendwie
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (ContainsEmail())
            {

            }
        }

        private bool ContainsEmail()
        {
            bool containsMail = true;
            if (TbEmail.Text.Contains("@"))
            {
                containsMail = false;
                MessageBox.Show("Your E-Mail Adress doesn't contain an @");
            }

            if (TbEmail.Text.Contains("."))
            {
                containsMail = false;
                MessageBox.Show("");
            }

            return containsMail;
        }

        private void TvEmails_SelectionChanged(object sender, EventArgs e)
        {
            _email = (Email) TvEmails.SelectedObject;
        }
    }
}
