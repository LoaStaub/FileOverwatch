using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseWindows.DatabaseModels;

namespace ExecutableWindows.ListForms
{
    public partial class Phones : Form
    {
        private static List<PhoneNumber> _numbers;
        private static PhoneNumber _number;
        public Phones(ref List<PhoneNumber> numbers)
        {
            _numbers = numbers;
            InitializeComponent();
        }

        private void BtnCall_Click(object sender, EventArgs e)
        {
            var phoner = "tel:" + _number.CountryFlag + _number.PhoneNr;
            Process.Start(phoner);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var number = _numbers.FirstOrDefault(d => d.Id == _number.Id);
            if (number != null)
            {
                number.Deleted = true;
                TvPhonenumbers.DisableObject(number);
            }
        }

        private void TvPhonenumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _number = (PhoneNumber) TvPhonenumbers.SelectedObject;
            TbDescription.Text = _number.Description;
            TbCountryFlag.Text = _number.CountryFlag;
            TbNumber.Text = _number.PhoneNr;
        }

        private void BtnNew_Click(object sender, EventArgs e)
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
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var number = _numbers.FirstOrDefault(d => d.Id == _number.Id);
            if (number != null)
            {
                number.Description = TbDescription.Text;
                number.CountryFlag = TbCountryFlag.Text;
                number.PhoneNr = TbNumber.Text;
                TvPhonenumbers.RefreshObject(number);
            }
        }
    }
}
