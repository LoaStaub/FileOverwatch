﻿using DatabaseWindows;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseWindows.DatabaseModels;
using Executable.Classes;
using ExecutableWindows.Models;
using Microsoft.Win32;

namespace ExecutableWindows
{
    public partial class OverlayForm : Form
    {
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
            ClearAllLabels();
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
            var organization = new Organization();
            var organizationForm = new CreateOrganization(ref organization);
            organizationForm.ShowDialog();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            TvOrganization.Items.Clear();
            var db = new DataBase();
            var organizations = await db.Organizations.Where(d => !d.Deleted).AsNoTracking().ToListAsync();
            TvOrganization.ShowGroups = false;
            TvOrganization.AddObjects(organizations);
        }

        private void BtnAddContextMenu_Click(object sender, EventArgs e)
        {
            //var key = Registry.ClassesRoot.OpenSubKey("Folder\\Shell", true);
            //var newKey = key.CreateSubKey("Add File to FileOverwatch");

        }

        private void BtnLinkFile_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void TvOrganization_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ClearAllLabels();
            TvGroupsMembers.Items.Clear();
            if (TvOrganization.SelectedObject != null)
            {
                var organization = (Organization) TvOrganization.SelectedObject;
                var db = new DataBase();
                var groups = await db.Groups.Where(d =>
                    !d.Deleted && d.OrganizationNode.Any(f => !f.Deleted && f.OrganizationId == organization.Id)).ToListAsync();

                foreach (var group in groups)
                {
                    var members = await db.Members
                        .Where(d => !d.Deleted && d.GroupNode.Any(f => !f.Deleted && f.GroupId == group.Id))
                        .ToListAsync();
                    var membersWithGroupList = members.Select(member => new MemberWithGroup
                        {
                            Picture = member.Picture,
                            Birthdate = member.Birthdate,
                            Id = member.Id,
                            Description = member.Description,
                            City = member.City,
                            LastName = member.LastName,
                            ZipCode = member.ZipCode,
                            Gender = member.Gender,
                            FirstName = member.FirstName,
                            State = member.State,
                            Street = member.Street,
                            HouseNumber = member.HouseNumber,
                            Country = member.Country,
                            CreateDate = member.CreateDate,
                            GroupName = @group.Name,
                            Group = group,
                            MemberDate = member.MemberDate
                        })
                        .ToList();
                    TvGroupsMembers.AddObjects(membersWithGroupList);
                    OrganizationLabels(ref organization);
                }
            }
        }

        private void BtnRefreshGroupsMembers_Click(object sender, EventArgs e)
        {

        }

        private void BtnFileLinking_Click(object sender, EventArgs e)
        {
            var newFileLinking = new FileAdder();
            newFileLinking.ShowDialog();
        }

        private void BtnFileGroup_Click(object sender, EventArgs e)
        {
            var fileHead = new FileOverhead();
            var createFileGroup = new CreateFilegroup(ref fileHead);
            createFileGroup.ShowDialog();
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

        private void TvGroupsMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAllLabels();
            var memberWithGroup = (MemberWithGroup) TvGroupsMembers.SelectedObject;

            MemberLabels(ref memberWithGroup, ((Organization) TvOrganization.SelectedObject).Name);
        }

        private void BtnEditOrganization_Click(object sender, EventArgs e)
        {
            var organization = (Organization) TvOrganization.SelectedObject;
            if (organization == null)
            {
                MessageBox.Show(@"Please select an organization");
                return;
            }
            var editOrganization = new CreateOrganization(ref organization);
            editOrganization.ShowDialog();
            TvOrganization.UpdateObject(organization);
        }

        private void ClearAllLabels()
        {
            LblType.Text = string.Empty;
            LblPath.Text = string.Empty;
            LblName.Text = string.Empty;
            LblBirthdate.Text = string.Empty;
            LblCity.Text = string.Empty;
            LblCountry.Text = string.Empty;
            LblCreateDate.Text = string.Empty;
            LblGender.Text = string.Empty;
            LblMemberOf.Text = string.Empty;
            LblNumber.Text = string.Empty;
            LblZip.Text = string.Empty;
            LblState.Text = string.Empty;
            LblStreet.Text = string.Empty;
            LblBirthDateDesc.Text = @"Birthdate:";
            LblGenderDesc.Text = @"Gender:";
            PbPicture.Image = null;
        }

        private void OrganizationLabels(ref Organization organization)
        {
            LblType.Text = @"Organization";
            LblName.Text = organization.Name;
            LblBirthdate.Text = organization.Founded.ToShortDateString();
            LblBirthDateDesc.Text = @"Founded:";
            LblCity.Text = organization.City;
            LblCountry.Text = organization.Country;
            LblCreateDate.Text = organization.CreateDate.ToString(CultureInfo.CurrentCulture);
            LblGender.Text = organization.Type;
            LblGenderDesc.Text = @"Type:";
            LblNumber.Text = string.Empty;
            LblZip.Text = string.Empty;
            LblState.Text = string.Empty;
            LblStreet.Text = string.Empty;
            PbPicture.Image = ImageByteConverter.BytesToImage(organization.Picture);
        }

        private void MemberLabels(ref MemberWithGroup member, string orgaName)
        {
            LblType.Text = @"Member";
            LblPath.Text = $@"{orgaName}/{member.GroupName}/{member.FirstName} {member.LastName}";
            LblName.Text = $@"{member.FirstName} {member.LastName}";
            LblBirthdate.Text = member.Birthdate.ToShortDateString();
            LblCity.Text = member.City;
            LblCountry.Text = member.Country;
            LblCreateDate.Text = member.CreateDate.ToShortDateString();
            LblGender.Text = member.Gender;
            LblMemberOf.Text = member.GroupName;
            LblNumber.Text = member.HouseNumber;
            LblZip.Text = member.ZipCode;
            LblState.Text = member.State;
            LblStreet.Text = member.Street;
            PbPicture.Image = ImageByteConverter.BytesToImage(member.Picture);
        }

        private void BtnEditGroup_Click(object sender, EventArgs e)
        {
            var group = ((MemberWithGroup) TvGroupsMembers.SelectedObject).Group;
            var editGroup = new CreateGroup(ref group);
        }
    }
}
