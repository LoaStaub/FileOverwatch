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
    public partial class Phones : Form
    {
        private static List<PhoneNumber> _numbers;
        private static PhoneNumber _number;
        private static bool _isOpenedByEditor;
        public Phones(ref List<PhoneNumber> numbers, bool isOpenedByEditor)
        {
            _numbers = numbers;
            _isOpenedByEditor = isOpenedByEditor;
            InitializeComponent();
        }

        private void BtnCall_Click(object sender, EventArgs e)
        {
            var phoner = "tel:" + _number.CountryFlag + _number.PhoneNr;
            Process.Start(phoner);
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            var number = _numbers.FirstOrDefault(d => d.Id == _number.Id);
            if (number != null)
            {
                number.Deleted = true;
                TvPhonenumbers.DisableObject(number);
                if (_isOpenedByEditor)
                {
                    return;
                }
                var db = new DataBase();
                db.Entry(number).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
        }

        private void TvPhonenumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _number = (PhoneNumber) TvPhonenumbers.SelectedObject;
            TbDescription.Text = _number.Description;
            TbCountryFlag.Text = _number.CountryFlag;
            TbNumber.Text = _number.PhoneNr;
        }

        private async void BtnNew_Click(object sender, EventArgs e)
        {
            var number = new PhoneNumber
            {
                Deleted = false,
                CountryFlag = TbCountryFlag.Text,
                CreateDate = DateTime.Now,
                Description = TbDescription.Text,
                PhoneNr = TbNumber.Text
            };
            _numbers.Add(number);
            TvPhonenumbers.AddObject(number);
            if (_isOpenedByEditor)
            {
                return;
            }
            var db = new DataBase();
            db.PhoneNumbers.Add(number);
            await db.SaveChangesAsync();
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            var number = _numbers.FirstOrDefault(d => d.Id == _number.Id);
            if (number != null)
            {
                number.Description = TbDescription.Text;
                number.CountryFlag = TbCountryFlag.Text;
                number.PhoneNr = TbNumber.Text;
                TvPhonenumbers.RefreshObject(number);
                if (_isOpenedByEditor)
                {
                    return;
                }
                var db = new DataBase();
                db.Entry(number).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
        }
    }
}
