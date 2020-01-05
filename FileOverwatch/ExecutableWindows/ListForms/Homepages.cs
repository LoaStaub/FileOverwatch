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
using DatabaseWindows.DatabaseModels.LinkingTables;

namespace ExecutableWindows.ListForms
{
    public partial class Homepages : Form
    {
        private static List<Homepage> _pages;
        private static Homepage _page;
        private static bool _isOpenedByEditor;
        private static int _id, _index;
        public Homepages(ref List<Homepage> pages, int id, int index, bool isOpenedByEditor)
        {
            _pages = pages;
            _isOpenedByEditor = isOpenedByEditor;
            _id = id;
            _index = index;
            InitializeComponent();
        }

        private async void BtnNew_Click(object sender, EventArgs e)
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
            if (_isOpenedByEditor)
            {
                return;
            }
            var db = new DataBase();
            switch (_index)
            {
                case 1:
                    var nodeToOrga = new HomepageToOrganization
                    {
                        CreateDate = DateTime.Now,
                        Deleted = false,
                        HomepageId = page.Id,
                        OrganizationId = _id
                    };
                    db.HomepageToOrganizationNode.Add(nodeToOrga);
                    break;
                case 2:
                    var nodeToGroup = new HomepageToGroup
                    {
                        CreateDate = DateTime.Now,
                        Deleted = false,
                        HomepageId = page.Id,
                        GroupId = _id
                    };
                    db.HomepageToGroupNode.Add(nodeToGroup);
                    break;
                case 3:
                    var nodeToMember = new HomepageToMember
                    {
                        CreateDate = DateTime.Now,
                        Deleted = false,
                        HomepageId = page.Id,
                        MemberId = _id
                    };
                    db.HomepageToMemberNode.Add(nodeToMember);
                    break;
            }
            db.Homepages.Add(page);
            await db.SaveChangesAsync();
        }

        private void TvPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            _page = (Homepage) TvPages.SelectedObject;
            TbDescription.Text = _page?.Description;
            TbLink.Text = _page?.Link;
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            var page = _pages.FirstOrDefault(d => d.Id == _page.Id);
            if (page != null)
            {
                page.Description = _page.Description;
                page.Link = _page.Link;
            }
            TvPages.UpdateObject(page);
            if (_isOpenedByEditor)
            {
                return;
            }
            var db = new DataBase();
            db.Entry(page).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        private void Homepages_Load(object sender, EventArgs e)
        {
            TvPages.ShowGroups = false;
            TvPages.ClearObjects();
            TvPages.AddObjects(_pages);
            if (_isOpenedByEditor) BtnDelete.Visible = false;
        }

        private void BtnOpenPage_Click(object sender, EventArgs e)
        {
            Process.Start(_page.Link);
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            var page = _pages.FirstOrDefault(d => d.Id == _page.Id);
            if (page != null)
            {
                page.Deleted = true;
                TvPages.DisableObject(page);
                var db = new DataBase();
                db.Entry(page).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
        }
    }
}
