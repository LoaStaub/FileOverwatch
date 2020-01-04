using System;
using Database.DatabaseModels;
using Database.DatabaseModels.LinkingTables;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public partial class DataBase : DbContext
    {
        private static bool _created = false;
        public DataBase()
        {
            if (!_created)
            {
                _created = true;
                //Database.EnsureDeleted();
                //Database.EnsureCreated();
            }
        }
        
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<FileOverhead> FileOverheads { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Homepage> Homepages { get; set; }
        public virtual DbSet<LinkedFile> LinkedFiles { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }

        #region LinkingTables

        public virtual DbSet<EmailToMember> EmailToMemberNode { get; set; }
        public virtual DbSet<EmailToGroup> EmailGroupNode { get; set; }
        public virtual DbSet<EmailToOrganization> EmailToOrganizationNode { get; set; }
        public virtual DbSet<FileToOverhead> FileToOverheadNode { get; set; }
        public virtual DbSet<HomepageToMember> HomepageToMemberNode { get; set; }
        public virtual DbSet<HomepageToGroup> HomepageToGroupNode { get; set; }
        public virtual DbSet<HomepageToOrganization> HomepageToOrganizationNode { get; set; }
        public virtual DbSet<OverheadToMember> OverheadToMemberNode { get; set; }
        public virtual DbSet<OverheadToOrganization> OverheadToOrganizationNode { get; set; }
        public virtual DbSet<OverheadToGroup> OverheadToGroupNode { get; set; }
        public virtual DbSet<GroupToOrganization> GroupToOrganizationNode { get; set; }
        public virtual DbSet<PhoneToOrganization> PhoneToOrganizationNode { get; set; }
        public virtual DbSet<PhoneToGroup> PhoneToGroupNode { get; set; }
        public virtual DbSet<PhoneToMember> PhoneToMemberNode { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\Users\a-p-i\source\repos\FileOverwatch\FileOverwatch\DatabaseWindows\FileOverwatch.db");
    }
}
