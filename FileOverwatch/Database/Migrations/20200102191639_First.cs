using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Mail = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExcelFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    Directory = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastAccess = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcelFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileOverheads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Icon = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileOverheads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Picture = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Homepages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homepages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinkedFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    Directory = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastAccess = table.Column<DateTime>(nullable: false),
                    Icon = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkedFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    HouseNumber = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MemberDate = table.Column<DateTime>(nullable: false),
                    Picture = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Founded = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    HouseNumber = table.Column<string>(nullable: true),
                    Picture = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CountryFlag = table.Column<string>(nullable: true),
                    PhoneNr = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WordFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    Directory = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastAccess = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExcelToOverhead",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ExcelFileId = table.Column<int>(nullable: true),
                    FileOverheadId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcelToOverhead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExcelToOverhead_ExcelFiles_ExcelFileId",
                        column: x => x.ExcelFileId,
                        principalTable: "ExcelFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExcelToOverhead_FileOverheads_FileOverheadId",
                        column: x => x.FileOverheadId,
                        principalTable: "FileOverheads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailToGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    EmailId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailToGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailToGroup_Emails_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Emails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailToGroup_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OverheadToGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    FileOverheadId = table.Column<int>(nullable: true),
                    GroupId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverheadToGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverheadToGroup_FileOverheads_FileOverheadId",
                        column: x => x.FileOverheadId,
                        principalTable: "FileOverheads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OverheadToGroup_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HomepageToGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    HomepageId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomepageToGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomepageToGroup_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomepageToGroup_Homepages_HomepageId",
                        column: x => x.HomepageId,
                        principalTable: "Homepages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileToOverhead",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LinkedFileId = table.Column<int>(nullable: true),
                    FileOverheadId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileToOverhead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileToOverhead_FileOverheads_FileOverheadId",
                        column: x => x.FileOverheadId,
                        principalTable: "FileOverheads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileToOverhead_LinkedFiles_LinkedFileId",
                        column: x => x.LinkedFileId,
                        principalTable: "LinkedFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailToMember",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    EmailId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailToMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailToMember_Emails_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Emails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailToMember_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupToMember",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupToMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupToMember_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupToMember_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomepageToMember",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    HomepageId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomepageToMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomepageToMember_Homepages_HomepageId",
                        column: x => x.HomepageId,
                        principalTable: "Homepages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomepageToMember_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OverheadToMember",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    FileOverheadId = table.Column<int>(nullable: true),
                    MemberId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverheadToMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverheadToMember_FileOverheads_FileOverheadId",
                        column: x => x.FileOverheadId,
                        principalTable: "FileOverheads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OverheadToMember_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailToOrganization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    EmailId = table.Column<int>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailToOrganization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailToOrganization_Emails_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Emails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailToOrganization_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupToOrganization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupToOrganization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupToOrganization_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupToOrganization_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomepageToOrganization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    HomepageId = table.Column<int>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomepageToOrganization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomepageToOrganization_Homepages_HomepageId",
                        column: x => x.HomepageId,
                        principalTable: "Homepages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomepageToOrganization_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OverheadToOrganization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    FileOverheadId = table.Column<int>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverheadToOrganization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverheadToOrganization_FileOverheads_FileOverheadId",
                        column: x => x.FileOverheadId,
                        principalTable: "FileOverheads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OverheadToOrganization_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhoneToGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    PhoneNumberId = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneToGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneToGroup_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneToGroup_PhoneNumbers_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalTable: "PhoneNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneToMember",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    PhoneNumberId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneToMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneToMember_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneToMember_PhoneNumbers_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalTable: "PhoneNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneToOrganization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    PhoneNumberId = table.Column<int>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneToOrganization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneToOrganization_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhoneToOrganization_PhoneNumbers_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalTable: "PhoneNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WordToOverhead",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    WordFileId = table.Column<int>(nullable: true),
                    FileOverheadId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordToOverhead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WordToOverhead_FileOverheads_FileOverheadId",
                        column: x => x.FileOverheadId,
                        principalTable: "FileOverheads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WordToOverhead_WordFiles_WordFileId",
                        column: x => x.WordFileId,
                        principalTable: "WordFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmailToGroup_EmailId",
                table: "EmailToGroup",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailToGroup_GroupId",
                table: "EmailToGroup",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailToMember_EmailId",
                table: "EmailToMember",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailToMember_MemberId",
                table: "EmailToMember",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailToOrganization_EmailId",
                table: "EmailToOrganization",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailToOrganization_OrganizationId",
                table: "EmailToOrganization",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExcelToOverhead_ExcelFileId",
                table: "ExcelToOverhead",
                column: "ExcelFileId");

            migrationBuilder.CreateIndex(
                name: "IX_ExcelToOverhead_FileOverheadId",
                table: "ExcelToOverhead",
                column: "FileOverheadId");

            migrationBuilder.CreateIndex(
                name: "IX_FileToOverhead_FileOverheadId",
                table: "FileToOverhead",
                column: "FileOverheadId");

            migrationBuilder.CreateIndex(
                name: "IX_FileToOverhead_LinkedFileId",
                table: "FileToOverhead",
                column: "LinkedFileId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupToMember_GroupId",
                table: "GroupToMember",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupToMember_MemberId",
                table: "GroupToMember",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupToOrganization_GroupId",
                table: "GroupToOrganization",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupToOrganization_OrganizationId",
                table: "GroupToOrganization",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_HomepageToGroup_GroupId",
                table: "HomepageToGroup",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_HomepageToGroup_HomepageId",
                table: "HomepageToGroup",
                column: "HomepageId");

            migrationBuilder.CreateIndex(
                name: "IX_HomepageToMember_HomepageId",
                table: "HomepageToMember",
                column: "HomepageId");

            migrationBuilder.CreateIndex(
                name: "IX_HomepageToMember_MemberId",
                table: "HomepageToMember",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_HomepageToOrganization_HomepageId",
                table: "HomepageToOrganization",
                column: "HomepageId");

            migrationBuilder.CreateIndex(
                name: "IX_HomepageToOrganization_OrganizationId",
                table: "HomepageToOrganization",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadToGroup_FileOverheadId",
                table: "OverheadToGroup",
                column: "FileOverheadId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadToGroup_GroupId",
                table: "OverheadToGroup",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadToMember_FileOverheadId",
                table: "OverheadToMember",
                column: "FileOverheadId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadToMember_MemberId",
                table: "OverheadToMember",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadToOrganization_FileOverheadId",
                table: "OverheadToOrganization",
                column: "FileOverheadId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadToOrganization_OrganizationId",
                table: "OverheadToOrganization",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneToGroup_GroupId",
                table: "PhoneToGroup",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneToGroup_PhoneNumberId",
                table: "PhoneToGroup",
                column: "PhoneNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneToMember_MemberId",
                table: "PhoneToMember",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneToMember_PhoneNumberId",
                table: "PhoneToMember",
                column: "PhoneNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneToOrganization_OrganizationId",
                table: "PhoneToOrganization",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneToOrganization_PhoneNumberId",
                table: "PhoneToOrganization",
                column: "PhoneNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_WordToOverhead_FileOverheadId",
                table: "WordToOverhead",
                column: "FileOverheadId");

            migrationBuilder.CreateIndex(
                name: "IX_WordToOverhead_WordFileId",
                table: "WordToOverhead",
                column: "WordFileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailToGroup");

            migrationBuilder.DropTable(
                name: "EmailToMember");

            migrationBuilder.DropTable(
                name: "EmailToOrganization");

            migrationBuilder.DropTable(
                name: "ExcelToOverhead");

            migrationBuilder.DropTable(
                name: "FileToOverhead");

            migrationBuilder.DropTable(
                name: "GroupToMember");

            migrationBuilder.DropTable(
                name: "GroupToOrganization");

            migrationBuilder.DropTable(
                name: "HomepageToGroup");

            migrationBuilder.DropTable(
                name: "HomepageToMember");

            migrationBuilder.DropTable(
                name: "HomepageToOrganization");

            migrationBuilder.DropTable(
                name: "OverheadToGroup");

            migrationBuilder.DropTable(
                name: "OverheadToMember");

            migrationBuilder.DropTable(
                name: "OverheadToOrganization");

            migrationBuilder.DropTable(
                name: "PhoneToGroup");

            migrationBuilder.DropTable(
                name: "PhoneToMember");

            migrationBuilder.DropTable(
                name: "PhoneToOrganization");

            migrationBuilder.DropTable(
                name: "WordToOverhead");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "ExcelFiles");

            migrationBuilder.DropTable(
                name: "LinkedFiles");

            migrationBuilder.DropTable(
                name: "Homepages");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "FileOverheads");

            migrationBuilder.DropTable(
                name: "WordFiles");
        }
    }
}
