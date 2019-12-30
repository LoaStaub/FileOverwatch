using DatabaseWindows;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseWindows.DatabaseModels;
using Microsoft.Win32;

namespace ExecutableWindows
{
    public partial class OverlayForm : Form
    {
        private int _organizationId, _employeeId, _groupId, _fileId;

        public OverlayForm()
        {
            InitializeComponent();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            OrgaHead();
        }

        private void OrgaHead()
        {
            var db = new DataBase();
            var orgaList = db.Organizations.Where(d => !d.Deleted).OrderByDescending(d => d.Name).ToList();
            //var OrgaOverheadNode = new TreeNode();
            foreach (var organization in orgaList)
            {
                var orgaTreeNode = new TreeNode
                {
                    Text = organization.Name,
                    Name = "Organization"
                };
                if (organization.GroupNode != null)
                {
                    foreach (var groupNode in organization.GroupNode)
                    {
                        if (!groupNode.Deleted)
                        {
                            var groupTreeNode = new TreeNode
                            {
                                Text = groupNode.Group.Name,
                                Name = "Gruppe"
                            };
                            foreach (var groupNode2 in groupNode.Group.MemberNode)
                            {
                                if (!groupNode2.Deleted)
                                {
                                    var employeeTreeNode = new TreeNode
                                    {
                                        Text = groupNode2.Member.FirstName + " " + groupNode2.Member.LastName,
                                        Name = "Employee"
                                    };
                                    groupTreeNode.Nodes.Add(employeeTreeNode);
                                }
                            }

                            orgaTreeNode.Nodes.Add(groupTreeNode);
                        }
                    }
                }

                //TvFileOverview.Nodes.Add(orgaTreeNode);
                var gr = new ListViewGroup
                {

                };
                //TvFileOverview.Groups.Add();
            }

        }

        private void AddMember()
        {
            var id = 0;
            var memberForm = new CreateMember(ref id);
            memberForm.ShowDialog();
        }

        private void AddGroup()
        {
            var id = 0;
            var groupForm = new CreateGroup(ref id);
            groupForm.ShowDialog();
        }

        private void AddOrganization()
        {
            var id = 0;
            var organizationForm = new CreateOrganization(ref id);
            organizationForm.ShowDialog();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            var organizations = await db.Organizations.Where(d => !d.Deleted).AsNoTracking().ToListAsync();
            objectListView1.AddObjects(organizations);
            TvOrganization.AddObjects(organizations);
        }

        private void BtnAddContextMenu_Click(object sender, EventArgs e)
        {
            var key = Registry.ClassesRoot.OpenSubKey("Folder\\Shell", true);
            var newKey = key.CreateSubKey("Add File to FileOverwatch");

        }

        private void BtnLinkFile_Click(object sender, EventArgs e)
        {
            var newFileLinking = new FileAdder();
            newFileLinking.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroup();
        }

        private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrganization();
        }
    }
}
