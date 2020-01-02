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
    public partial class Members : Form
    {
        private static List<Member> _members;
        public Members(ref List<Member> members)
        {
            _members = members;
            InitializeComponent();
        }
    }
}
