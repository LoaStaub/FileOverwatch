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
    public partial class Homepages : Form
    {
        private static List<Homepage> _pages;
        private static Homepage _page;
        public Homepages(ref List<Homepage> pages)
        {
            _pages = pages;
            InitializeComponent();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var page = new Homepage
            {
                CreateDate = DateTime.Now,
                Deleted = false,
                Description = TbDescription.Text,
                Link = TbLink.Text
            };
            _pages.Add(page);
            TvPages.AddObject(page);
        }

        private void TvPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            _page = (Homepage) TvPages.SelectedObject;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var page = _pages.FirstOrDefault(d => d.Id == _page.Id);
            if (page != null)
            {
                page.Description = _page.Description;
                page.Link = _page.Link;
            }
            TvPages.UpdateObject(page);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var page = _pages.FirstOrDefault(d => d.Id == _page.Id);
            if (page != null)
            {
                page.Deleted = true;
                TvPages.DisableObject(page);
            }
        }
    }
}
