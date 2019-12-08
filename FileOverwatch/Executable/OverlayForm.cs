using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace Executable
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
                TvFileOverview.Nodes.Add(orgaTreeNode);
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
