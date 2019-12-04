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
                        foreach (var groupNode2 in groupNode.Group.EmployeeNode)
                        {
                            if (!groupNode2.Deleted)
                            {
                                var employeeTreeNode = new TreeNode
                                {
                                    Text = groupNode2.Employee.FirstName + " " + groupNode2.Employee.LastName,
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

        private void AddEmployee()
        {

        }

        private void AddGroup()
        {

        }
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lol = 0;
            var orgaForm = new CreateOrganization(ref lol);
            orgaForm.ShowDialog();
        }
    }
}
