using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseWindows.DatabaseModels;

namespace ExecutableWindows.ListForms
{
    public partial class Groups : Form
    {
        private static List<Group> _groups;
        public Groups(ref List<Group> groups)
        {
            _groups = groups;
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {

        }
    }
}
