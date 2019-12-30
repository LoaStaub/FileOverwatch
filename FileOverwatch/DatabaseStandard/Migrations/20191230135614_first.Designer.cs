﻿// <auto-generated />
using System;
using DatabaseStandard;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabaseStandard.Migrations
{
    [DbContext(typeof(DataBase))]
    [Migration("20191230135614_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.ExcelFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Directory")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastAccess")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ExcelFiles");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.FileOverhead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Icon")
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FileOverheads");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.Homepage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Homepages");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkedFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Directory")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Icon")
                        .HasColumnType("BLOB");

                    b.Property<DateTime>("LastAccess")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("LinkedFiles");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.EmailToGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EmailId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GroupId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EmailId");

                    b.HasIndex("GroupId");

                    b.ToTable("EmailGroupNode");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.EmailToMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EmailId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MemberId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EmailId");

                    b.HasIndex("MemberId");

                    b.ToTable("EmailToEmployeeNode");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.EmailToOrganization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EmailId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EmailId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("EmailToOrganizationNode");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.ExcelToOverhead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ExcelFileId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FileOverheadId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExcelFileId");

                    b.HasIndex("FileOverheadId");

                    b.ToTable("ExcelToOverheadNode");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.FileToOverhead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FileOverheadId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LinkedFileId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FileOverheadId");

                    b.HasIndex("LinkedFileId");

                    b.ToTable("FileToOverheadNode");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.GroupToMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MemberId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("MemberId");

                    b.ToTable("GroupToMember");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.GroupToOrganization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("GroupToOrganization");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.HomepageToGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HomepageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("HomepageId");

                    b.ToTable("HomepageToGroupNode");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.HomepageToMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HomepageId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MemberId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("HomepageId");

                    b.HasIndex("MemberId");

                    b.ToTable("HomepageToEmployeeNode");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.HomepageToOrganization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HomepageId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("HomepageId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("HomepageToOrganizationNode");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.OverheadToGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FileOverheadId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GroupId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FileOverheadId");

                    b.HasIndex("GroupId");

                    b.ToTable("OverheadToGroupNode");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.OverheadToMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FileOverheadId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MemberId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FileOverheadId");

                    b.HasIndex("MemberId");

                    b.ToTable("OverheadToEmployeeNode");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.OverheadToOrganization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FileOverheadId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FileOverheadId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("OverheadToOrganizationNode");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.PhoneToGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PhoneNumberId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("PhoneNumberId");

                    b.ToTable("PhoneToGroup");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.PhoneToMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MemberId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PhoneNumberId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("PhoneNumberId");

                    b.ToTable("PhoneToMember");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.PhoneToOrganization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PhoneNumberId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("PhoneNumberId");

                    b.ToTable("PhoneToOrganization");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.WordToOverhead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FileOverheadId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("WordFileId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FileOverheadId");

                    b.HasIndex("WordFileId");

                    b.ToTable("WordToOverheadNode");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("MemberDate")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("BLOB");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Founded")
                        .HasColumnType("TEXT");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("BLOB");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.PhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CountryFlag")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNr")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.WordFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Directory")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastAccess")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WordFiles");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.EmailToGroup", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.Email", "Email")
                        .WithMany("GroupNode")
                        .HasForeignKey("EmailId");

                    b.HasOne("DatabaseStandard.DatabaseModels.Group", "Group")
                        .WithMany("EmailNode")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.EmailToMember", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.Email", "Email")
                        .WithMany("EmployeeNode")
                        .HasForeignKey("EmailId");

                    b.HasOne("DatabaseStandard.DatabaseModels.Member", "Member")
                        .WithMany("EmailNode")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.EmailToOrganization", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.Email", "Email")
                        .WithMany("OrganizationNode")
                        .HasForeignKey("EmailId");

                    b.HasOne("DatabaseStandard.DatabaseModels.Organization", "Organization")
                        .WithMany("EmailNode")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.ExcelToOverhead", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.ExcelFile", "ExcelFile")
                        .WithMany("OverheadNode")
                        .HasForeignKey("ExcelFileId");

                    b.HasOne("DatabaseStandard.DatabaseModels.FileOverhead", "FileOverhead")
                        .WithMany("ExcelNode")
                        .HasForeignKey("FileOverheadId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.FileToOverhead", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.FileOverhead", "FileOverhead")
                        .WithMany("FileNode")
                        .HasForeignKey("FileOverheadId");

                    b.HasOne("DatabaseStandard.DatabaseModels.LinkedFile", "LinkedFile")
                        .WithMany("OverheadNode")
                        .HasForeignKey("LinkedFileId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.GroupToMember", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.Group", "Group")
                        .WithMany("MemberNode")
                        .HasForeignKey("GroupId");

                    b.HasOne("DatabaseStandard.DatabaseModels.Member", "Member")
                        .WithMany("GroupNode")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.GroupToOrganization", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.Group", "Group")
                        .WithMany("OrganizationNode")
                        .HasForeignKey("GroupId");

                    b.HasOne("DatabaseStandard.DatabaseModels.Organization", "Organization")
                        .WithMany("GroupNode")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.HomepageToGroup", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.Group", "Group")
                        .WithMany("HomepageNode")
                        .HasForeignKey("GroupId");

                    b.HasOne("DatabaseStandard.DatabaseModels.Homepage", "Homepage")
                        .WithMany("GroupNode")
                        .HasForeignKey("HomepageId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.HomepageToMember", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.Homepage", "Homepage")
                        .WithMany("EmployeeNode")
                        .HasForeignKey("HomepageId");

                    b.HasOne("DatabaseStandard.DatabaseModels.Member", "Member")
                        .WithMany("HomepageNode")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.HomepageToOrganization", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.Homepage", "Homepage")
                        .WithMany("OrganizationNode")
                        .HasForeignKey("HomepageId");

                    b.HasOne("DatabaseStandard.DatabaseModels.Organization", "Organization")
                        .WithMany("HomepageNode")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.OverheadToGroup", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.FileOverhead", "FileOverhead")
                        .WithMany("GroupNode")
                        .HasForeignKey("FileOverheadId");

                    b.HasOne("DatabaseStandard.DatabaseModels.Group", "Group")
                        .WithMany("OverheadNode")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.OverheadToMember", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.FileOverhead", "FileOverhead")
                        .WithMany("EmployeeNode")
                        .HasForeignKey("FileOverheadId");

                    b.HasOne("DatabaseStandard.DatabaseModels.Member", "Member")
                        .WithMany("OverheadNode")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.OverheadToOrganization", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.FileOverhead", "FileOverhead")
                        .WithMany("OrganizationNode")
                        .HasForeignKey("FileOverheadId");

                    b.HasOne("DatabaseStandard.DatabaseModels.Organization", "Organization")
                        .WithMany("OverheadNode")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.PhoneToGroup", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.Group", "Group")
                        .WithMany("PhoneNode")
                        .HasForeignKey("GroupId");

                    b.HasOne("DatabaseStandard.DatabaseModels.PhoneNumber", "PhoneNumber")
                        .WithMany("GroupNode")
                        .HasForeignKey("PhoneNumberId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.PhoneToMember", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.Member", "Member")
                        .WithMany("PhoneNode")
                        .HasForeignKey("MemberId");

                    b.HasOne("DatabaseStandard.DatabaseModels.PhoneNumber", "PhoneNumber")
                        .WithMany("MemberNode")
                        .HasForeignKey("PhoneNumberId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.PhoneToOrganization", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.Organization", "Organization")
                        .WithMany("PhoneNode")
                        .HasForeignKey("OrganizationId");

                    b.HasOne("DatabaseStandard.DatabaseModels.PhoneNumber", "PhoneNumber")
                        .WithMany("OrganizationNode")
                        .HasForeignKey("PhoneNumberId");
                });

            modelBuilder.Entity("DatabaseStandard.DatabaseModels.LinkingTables.WordToOverhead", b =>
                {
                    b.HasOne("DatabaseStandard.DatabaseModels.FileOverhead", "FileOverhead")
                        .WithMany("WordNode")
                        .HasForeignKey("FileOverheadId");

                    b.HasOne("DatabaseStandard.DatabaseModels.WordFile", "WordFile")
                        .WithMany("OverheadNode")
                        .HasForeignKey("WordFileId");
                });
#pragma warning restore 612, 618
        }
    }
}
