using DatabaseWindows;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseWindows.DatabaseModels;
using Executable.Classes;
using ExecutableWindows.ListForms;
using ExecutableWindows.Models;
using Microsoft.Win32;

namespace ExecutableWindows
{
    public partial class OverlayForm : Form
    {
        private static bool _isItOrganization;
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
            var group = new Group();
            var groupForm = new CreateGroup(ref group);
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
            _isItOrganization = true;
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
                            MemberDate = member.MemberDate,
                            Member = member
                        })
                        .ToList();
                    TvGroupsMembers.AddObjects(membersWithGroupList);
                    OrganizationLabels(ref organization);
                }
            }
        }

        private void BtnFileLinking_Click(object sender, EventArgs e)
        {
            var newFileLinking = new FileAdder();
            newFileLinking.ShowDialog();
        }

        private void BtnFileGroup_Click(object sender, EventArgs e)
        {
            var fileHead = new FileOverhead();
            var createFileGroup = new CreateFilegroup(ref fileHead, false);
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

        private async void TvGroupsMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isItOrganization = false;

            ClearAllLabels();
            if ((MemberWithGroup) TvGroupsMembers.SelectedObject == null)
            {
                return;
            }
            var memberWithGroup = (MemberWithGroup) TvGroupsMembers.SelectedObject;

            MemberLabels(ref memberWithGroup, ((Organization) TvOrganization.SelectedObject).Name);
            var db = new DataBase();
            var fileOverheads = await db.FileOverheads
                .Where(d => !d.Deleted && d.MemberNode.Any(f => !f.Deleted && f.MemberId == memberWithGroup.Id))
                .ToListAsync();

            var fileList = new List<FileWithOverhead>();
            foreach (var fileOverhead in fileOverheads)
            {
                var files = await db.LinkedFiles.Where(d =>
                    !d.Deleted && d.OverheadNode.Any(f =>
                        !f.Deleted && !f.FileOverhead.Deleted && f.FileOverhead.Id == fileOverhead.Id)).ToListAsync();
                foreach (var file in files)
                {
                    var fileWithOverhead = new FileWithOverhead
                    {
                        CreateDate = file.CreateDate,
                        Deleted = file.Deleted,
                        Description = file.Description,
                        Directory = file.Directory,
                        FileName = file.FileName,
                        FileOverhead = fileOverhead,
                        GroupName = fileOverhead.Name,
                        Icon = file.Icon,
                        Id = file.Id,
                        LastAccess = file.LastAccess,
                        LinkedFile = file
                    };
                    fileList.Add(fileWithOverhead);
                }
            }

            TvFiles.AddObjects(fileList);
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
            LblPath.Text = $@"{orgaName}/{member?.GroupName}/{member?.FirstName} {member?.LastName}";
            LblName.Text = $@"{member?.FirstName} {member?.LastName}";
            LblBirthdate.Text = member?.Birthdate.ToShortDateString();
            LblCity.Text = member?.City;
            LblCountry.Text = member?.Country;
            LblCreateDate.Text = member?.CreateDate.ToShortDateString();
            LblGender.Text = member?.Gender;
            LblMemberOf.Text = member?.GroupName;
            LblNumber.Text = member?.HouseNumber;
            LblZip.Text = member?.ZipCode;
            LblState.Text = member?.State;
            LblStreet.Text = member?.Street;
            PbPicture.Image = ImageByteConverter.BytesToImage(member?.Picture);
        }

        private void FileLabels(ref FileWithOverhead file, string path)
        {
            LblType.Text = @"File";
            LblPath.Text = $@"{path}/{file?.GroupName}/{file?.FileName}";
            LblName.Text = file?.FileName;
            LblBirthdate.Text = file?.CreateDate.ToShortDateString();
        }

        private void BtnEditGroup_Click(object sender, EventArgs e)
        {
            var group = ((MemberWithGroup) TvGroupsMembers.SelectedObject).Group;
            var editGroup = new CreateGroup(ref group);
            editGroup.ShowDialog();
            ((MemberWithGroup) TvGroupsMembers.SelectedObject).GroupName = group.Name;
            TvGroupsMembers.UpdateObject((MemberWithGroup)TvGroupsMembers.SelectedObject);
        }

        private async void BtnPhones_Click(object sender, EventArgs e)
        {
            if (_isItOrganization)
            {
                var orga = (Organization) TvOrganization.SelectedObject;
                var db = new DataBase();
                var phoneList = await db.PhoneNumbers.Where(d =>
                    !d.Deleted && d.OrganizationNode.Any(f => f.Organization.Id == orga.Id)).ToListAsync();
                var phone = new Phones(ref phoneList, orga.Id, 1, false);
                phone.Show();
            }
            else
            {
                var member = ((MemberWithGroup) TvGroupsMembers.SelectedObject).Member;
                var group = ((MemberWithGroup)TvGroupsMembers.SelectedObject).Group;
                var doYouMean = new DoYouMean(ref group, ref member, 1);
                doYouMean.Show();
            }
        }

        private async void BtnEmail_Click(object sender, EventArgs e)
        {
            if (_isItOrganization)
            {
                var orga = (Organization)TvOrganization.SelectedObject;
                var db = new DataBase();
                var emailList = await db.Emails.Where(d =>
                    !d.Deleted && d.OrganizationNode.Any(f => f.Organization.Id == orga.Id)).ToListAsync();
                var emailForm = new Emails(ref emailList, orga.Id, 1, false);
                emailForm.Show();
            }
            else
            {
                var member = ((MemberWithGroup)TvGroupsMembers.SelectedObject).Member;
                var group = ((MemberWithGroup)TvGroupsMembers.SelectedObject).Group;
                var doYouMean = new DoYouMean(ref group, ref member, 2);
                doYouMean.Show();
            }
        }

        private async void BtnHomepage_Click(object sender, EventArgs e)
        {
            if (_isItOrganization)
            {
                var orga = (Organization)TvOrganization.SelectedObject;
                var db = new DataBase();
                var homepageList = await db.Homepages.Where(d =>
                    !d.Deleted && d.OrganizationNode.Any(f => f.Organization.Id == orga.Id)).ToListAsync();
                var homepageForm = new Homepages(ref homepageList, orga.Id, 1, false);
                homepageForm.Show();
            }
            else
            {
                var member = ((MemberWithGroup)TvGroupsMembers.SelectedObject).Member;
                var group = ((MemberWithGroup)TvGroupsMembers.SelectedObject).Group;
                var doYouMean = new DoYouMean(ref group, ref member, 3);
                doYouMean.Show();
            }
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {

        }

        private void BtnFullCleanUp_Click(object sender, EventArgs e)
        {

        }

        private void TvFiles_DoubleClick(object sender, EventArgs e)
        {
            var file = (FileWithOverhead) TvFiles.SelectedObject;
            if (Directory.Exists(file.Directory))
            {
                Process.Start(file.Directory);
            }
            else
            {
                MessageBox.Show("File doesn't exist anymore");
            }
        }

        private void TvFiles_SelectionChanged(object sender, EventArgs e)
        {
            var path = LblPath.Text;
            var file = (FileWithOverhead) TvFiles.SelectedObject;
            if (file == null)
            {
                return;
            }
            ClearAllLabels();
            FileLabels(ref file, path);
        }
    }
}
