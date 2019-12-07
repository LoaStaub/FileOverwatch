using System;
using Database.DatabaseModels;
using Database.DatabaseModels.LinkingTables;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public partial class DataBase : DbContext
    {
        public DataBase()
            //: base("name=ApiDb")
        {
        }
        
        public virtual DbSet<Member> Employees { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<ExcelFile> ExcelFiles { get; set; }
        public virtual DbSet<FileOverhead> FileOverheads { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Homepage> Homepages { get; set; }
        public virtual DbSet<LinkedFile> LinkedFiles { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<WordFile> WordFiles { get; set; }

        #region LinkingTables

        public virtual DbSet<EmailToMember> EmailToEmployeeNode { get; set; }
        public virtual DbSet<EmailToGroup> EmailGroupNode { get; set; }
        public virtual DbSet<EmailToOrganization> EmailToOrganizationNode { get; set; }
        public virtual DbSet<ExcelToOverhead> ExcelToOverheadNode { get; set; }
        public virtual DbSet<FileToOverhead> FileToOverheadNode { get; set; }
        public virtual DbSet<HomepageToMember> HomepageToEmployeeNode { get; set; }
        public virtual DbSet<HomepageToGroup> HomepageToGroupNode { get; set; }
        public virtual DbSet<HomepageToOrganization> HomepageToOrganizationNode { get; set; }
        public virtual DbSet<OverheadToMember> OverheadToEmployeeNode { get; set; }
        public virtual DbSet<OverheadToOrganization> OverheadToOrganizationNode { get; set; }
        public virtual DbSet<WordToOverhead> WordToOverheadNode { get; set; }

        #endregion
    }
}
