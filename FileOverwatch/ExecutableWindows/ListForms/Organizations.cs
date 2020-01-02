using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecutableWindows.ListForms
{
    public partial class Organizations : Form
    {
        private static List<Organizations> _organizations;
        public Organizations(ref List<Organizations> organizations)
        {
            _organizations = organizations;
            InitializeComponent();
        }
    }
}
