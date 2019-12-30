﻿using System;
using System.Data.Entity;
using DatabaseWindows.DatabaseModels;
using DatabaseWindows.DatabaseModels.LinkingTables;

namespace DatabaseWindows
{
    public partial class DataBase : DbContext
    {
        public DataBase(): base("name=DataBase")
        {

        }
        
        public virtual DbSet<Member> Members { get; set; }
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
        public virtual DbSet<OverheadToGroup> OverheadToGroupNode { get; set; }
        public virtual DbSet<GroupToOrganization> GroupToOrganizationNode { get; set; }


        #endregion

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite(@"Data Source=C:\Users\a-p-i\source\repos\FileOverwatch\FileOverwatch\Database\FileOverwatch.db");
    }
}
