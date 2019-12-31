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
    public partial class CreateFilegroup : Form
    {
        private FileOverhead _fileOverhead;
        public CreateFilegroup(ref FileOverhead fileOverhead)
        {
            _fileOverhead = fileOverhead;
            InitializeComponent();
        }

        private void BtnAbort_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            _fileOverhead.Deleted = true;
            await db.SaveChangesAsync();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            _fileOverhead.Deleted = false;
            _fileOverhead.Description = TbDescription.Text;
            _fileOverhead.Name = TbName.Text;
            if (_fileOverhead.Id == 0)
            {
                _fileOverhead.CreateDate = DateTime.Now;
                db.FileOverheads.Add(_fileOverhead);
            }

            await db.SaveChangesAsync();
        }
    }
}
