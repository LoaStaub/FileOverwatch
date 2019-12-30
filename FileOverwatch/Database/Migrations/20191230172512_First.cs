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
                    Description = table.Column<string>(nullable: true)
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
                name: "ExcelToOverheadNode",
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
                    table.PrimaryKey("PK_ExcelToOverheadNode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExcelToOverheadNode_ExcelFiles_ExcelFileId",
                        column: x => x.ExcelFileId,
                        principalTable: "ExcelFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExcelToOverheadNode_FileOverheads_FileOverheadId",
                        column: x => x.FileOverheadId,
                        principalTable: "FileOverheads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailGroupNode",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    EmailId = table.Column<int>(nullable: true),
                    GroupId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailGroupNode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailGroupNode_Emails_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Emails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailGroupNode_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OverheadToGroupNode",
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
                    table.PrimaryKey("PK_OverheadToGroupNode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverheadToGroupNode_FileOverheads_FileOverheadId",
                        column: x => x.FileOverheadId,
                        principalTable: "FileOverheads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OverheadToGroupNode_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HomepageToGroupNode",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    HomepageId = table.Column<int>(nullable: true),
                    GroupId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomepageToGroupNode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomepageToGroupNode_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomepageToGroupNode_Homepages_HomepageId",
                        column: x => x.HomepageId,
                        principalTable: "Homepages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileToOverheadNode",
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
                    table.PrimaryKey("PK_FileToOverheadNode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileToOverheadNode_FileOverheads_FileOverheadId",
                        column: x => x.FileOverheadId,
                        principalTable: "FileOverheads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileToOverheadNode_LinkedFiles_LinkedFileId",
                        column: x => x.LinkedFileId,
                        principalTable: "LinkedFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailToEmployeeNode",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    EmailId = table.Column<int>(nullable: true),
                    MemberId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailToEmployeeNode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailToEmployeeNode_Emails_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Emails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailToEmployeeNode_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupToMember",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    GroupId = table.Column<int>(nullable: true),
                    MemberId = table.Column<int>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupToMember_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HomepageToEmployeeNode",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    HomepageId = table.Column<int>(nullable: true),
                    MemberId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomepageToEmployeeNode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomepageToEmployeeNode_Homepages_HomepageId",
                        column: x => x.HomepageId,
                        principalTable: "Homepages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomepageToEmployeeNode_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OverheadToEmployeeNode",
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
                    table.PrimaryKey("PK_OverheadToEmployeeNode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverheadToEmployeeNode_FileOverheads_FileOverheadId",
                        column: x => x.FileOverheadId,
                        principalTable: "FileOverheads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OverheadToEmployeeNode_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailToOrganizationNode",
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
                    table.PrimaryKey("PK_EmailToOrganizationNode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailToOrganizationNode_Emails_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Emails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailToOrganizationNode_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupToOrganizations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    GroupId = table.Column<int>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupToOrganizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupToOrganizations_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupToOrganizations_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HomepageToOrganizationNode",
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
                    table.PrimaryKey("PK_HomepageToOrganizationNode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomepageToOrganizationNode_Homepages_HomepageId",
                        column: x => x.HomepageId,
                        principalTable: "Homepages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomepageToOrganizationNode_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OverheadToOrganizationNode",
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
                    table.PrimaryKey("PK_OverheadToOrganizationNode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverheadToOrganizationNode_FileOverheads_FileOverheadId",
                        column: x => x.FileOverheadId,
                        principalTable: "FileOverheads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OverheadToOrganizationNode_Organizations_OrganizationId",
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
                    PhoneNumberId = table.Column<int>(nullable: true),
                    GroupId = table.Column<int>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhoneToGroup_PhoneNumbers_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalTable: "PhoneNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhoneToMember",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    PhoneNumberId = table.Column<int>(nullable: true),
                    MemberId = table.Column<int>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhoneToMember_PhoneNumbers_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalTable: "PhoneNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "WordToOverheadNode",
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
                    table.PrimaryKey("PK_WordToOverheadNode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WordToOverheadNode_FileOverheads_FileOverheadId",
                        column: x => x.FileOverheadId,
                        principalTable: "FileOverheads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WordToOverheadNode_WordFiles_WordFileId",
                        column: x => x.WordFileId,
                        principalTable: "WordFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmailGroupNode_EmailId",
                table: "EmailGroupNode",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailGroupNode_GroupId",
                table: "EmailGroupNode",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailToEmployeeNode_EmailId",
                table: "EmailToEmployeeNode",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailToEmployeeNode_MemberId",
                table: "EmailToEmployeeNode",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailToOrganizationNode_EmailId",
                table: "EmailToOrganizationNode",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailToOrganizationNode_OrganizationId",
                table: "EmailToOrganizationNode",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExcelToOverheadNode_ExcelFileId",
                table: "ExcelToOverheadNode",
                column: "ExcelFileId");

            migrationBuilder.CreateIndex(
                name: "IX_ExcelToOverheadNode_FileOverheadId",
                table: "ExcelToOverheadNode",
                column: "FileOverheadId");

            migrationBuilder.CreateIndex(
                name: "IX_FileToOverheadNode_FileOverheadId",
                table: "FileToOverheadNode",
                column: "FileOverheadId");

            migrationBuilder.CreateIndex(
                name: "IX_FileToOverheadNode_LinkedFileId",
                table: "FileToOverheadNode",
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
                name: "IX_GroupToOrganizations_GroupId",
                table: "GroupToOrganizations",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupToOrganizations_OrganizationId",
                table: "GroupToOrganizations",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_HomepageToEmployeeNode_HomepageId",
                table: "HomepageToEmployeeNode",
                column: "HomepageId");

            migrationBuilder.CreateIndex(
                name: "IX_HomepageToEmployeeNode_MemberId",
                table: "HomepageToEmployeeNode",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_HomepageToGroupNode_GroupId",
                table: "HomepageToGroupNode",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_HomepageToGroupNode_HomepageId",
                table: "HomepageToGroupNode",
                column: "HomepageId");

            migrationBuilder.CreateIndex(
                name: "IX_HomepageToOrganizationNode_HomepageId",
                table: "HomepageToOrganizationNode",
                column: "HomepageId");

            migrationBuilder.CreateIndex(
                name: "IX_HomepageToOrganizationNode_OrganizationId",
                table: "HomepageToOrganizationNode",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadToEmployeeNode_FileOverheadId",
                table: "OverheadToEmployeeNode",
                column: "FileOverheadId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadToEmployeeNode_MemberId",
                table: "OverheadToEmployeeNode",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadToGroupNode_FileOverheadId",
                table: "OverheadToGroupNode",
                column: "FileOverheadId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadToGroupNode_GroupId",
                table: "OverheadToGroupNode",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadToOrganizationNode_FileOverheadId",
                table: "OverheadToOrganizationNode",
                column: "FileOverheadId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadToOrganizationNode_OrganizationId",
                table: "OverheadToOrganizationNode",
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
                name: "IX_WordToOverheadNode_FileOverheadId",
                table: "WordToOverheadNode",
                column: "FileOverheadId");

            migrationBuilder.CreateIndex(
                name: "IX_WordToOverheadNode_WordFileId",
                table: "WordToOverheadNode",
                column: "WordFileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailGroupNode");

            migrationBuilder.DropTable(
                name: "EmailToEmployeeNode");

            migrationBuilder.DropTable(
                name: "EmailToOrganizationNode");

            migrationBuilder.DropTable(
                name: "ExcelToOverheadNode");

            migrationBuilder.DropTable(
                name: "FileToOverheadNode");

            migrationBuilder.DropTable(
                name: "GroupToMember");

            migrationBuilder.DropTable(
                name: "GroupToOrganizations");

            migrationBuilder.DropTable(
                name: "HomepageToEmployeeNode");

            migrationBuilder.DropTable(
                name: "HomepageToGroupNode");

            migrationBuilder.DropTable(
                name: "HomepageToOrganizationNode");

            migrationBuilder.DropTable(
                name: "OverheadToEmployeeNode");

            migrationBuilder.DropTable(
                name: "OverheadToGroupNode");

            migrationBuilder.DropTable(
                name: "OverheadToOrganizationNode");

            migrationBuilder.DropTable(
                name: "PhoneToGroup");

            migrationBuilder.DropTable(
                name: "PhoneToMember");

            migrationBuilder.DropTable(
                name: "PhoneToOrganization");

            migrationBuilder.DropTable(
                name: "WordToOverheadNode");

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
