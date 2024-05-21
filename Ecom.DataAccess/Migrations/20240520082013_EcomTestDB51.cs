using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EcomTestDB51 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: true),
                    FiscalYear = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DropdownV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Para = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParaModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParaId = table.Column<int>(type: "int", nullable: true),
                    ParentParaId = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DropdownV", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FiscalYear",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiscalYear", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Machinary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    JobStepId = table.Column<int>(type: "int", nullable: true),
                    JobStep = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machinary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasePrice = table.Column<double>(type: "float", nullable: true),
                    CostPrice = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FiscalYear = table.Column<int>(type: "int", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    FormaNumber = table.Column<int>(type: "int", nullable: true),
                    SubjectLanguageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectLanguages = table.Column<int>(type: "int", nullable: true),
                    SubjectTypeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectTypes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Products_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Products_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Forma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Page = table.Column<int>(type: "int", nullable: true),
                    PrintTarget = table.Column<int>(type: "int", nullable: true),
                    PrintAchieved = table.Column<int>(type: "int", nullable: true),
                    AssociatedFormaId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forma_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobTicket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: true),
                    PrintTarget = table.Column<int>(type: "int", nullable: true),
                    JobDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    JobStartDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    JobCompleteDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    LotNumber = table.Column<int>(type: "int", nullable: true),
                    JobTypeId = table.Column<int>(type: "int", nullable: false),
                    PrintAchieved = table.Column<int>(type: "int", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    FiscalYearId = table.Column<int>(type: "int", nullable: true),
                    PrePrintSize = table.Column<int>(type: "int", nullable: true),
                    JobStepId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobStep = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTicket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTicket_FiscalYear_FiscalYearId",
                        column: x => x.FiscalYearId,
                        principalTable: "FiscalYear",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobTicket_JobType_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobTicket_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MachineJobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    JobTicketId = table.Column<int>(type: "int", nullable: false),
                    MachinaryId = table.Column<int>(type: "int", nullable: false),
                    FormaId = table.Column<int>(type: "int", nullable: false),
                    JobDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FormaPageSize = table.Column<int>(type: "int", nullable: true),
                    JobQuantity = table.Column<int>(type: "int", nullable: true),
                    FormaTarget = table.Column<int>(type: "int", nullable: true),
                    JobTypeId = table.Column<int>(type: "int", nullable: false),
                    JobStepId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobStep = table.Column<int>(type: "int", nullable: true),
                    ShiftId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shift = table.Column<int>(type: "int", nullable: true),
                    ShiftDurationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftDuration = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorId = table.Column<int>(type: "int", nullable: true),
                    InchargeId = table.Column<int>(type: "int", nullable: true),
                    OperatorId = table.Column<int>(type: "int", nullable: true),
                    FiscalYear = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MachineJobs_Forma_FormaId",
                        column: x => x.FormaId,
                        principalTable: "Forma",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MachineJobs_JobTicket_JobTicketId",
                        column: x => x.JobTicketId,
                        principalTable: "JobTicket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachineJobs_JobType_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MachineJobs_Machinary_MachinaryId",
                        column: x => x.MachinaryId,
                        principalTable: "Machinary",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MachineJobs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "P2M",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P2M_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    P2MDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JobTicketId = table.Column<int>(type: "int", nullable: true),
                    FormaNumber = table.Column<int>(type: "int", nullable: true),
                    PerPokaSize = table.Column<int>(type: "int", nullable: true),
                    DropdownVId = table.Column<int>(type: "int", nullable: true),
                    PokaNumber = table.Column<int>(type: "int", nullable: true),
                    ProductQuantity = table.Column<int>(type: "int", nullable: true),
                    PiecesQuantity = table.Column<int>(type: "int", nullable: true),
                    TotalProductQuantity = table.Column<int>(type: "int", nullable: true),
                    JobStepId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobStep = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckedById = table.Column<int>(type: "int", nullable: true),
                    VerifiedById = table.Column<int>(type: "int", nullable: true),
                    ReceivedById = table.Column<int>(type: "int", nullable: true),
                    FiscalYear = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P2M", x => x.Id);
                    table.ForeignKey(
                        name: "FK_P2M_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_P2M_DropdownV_DropdownVId",
                        column: x => x.DropdownVId,
                        principalTable: "DropdownV",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_P2M_JobTicket_JobTicketId",
                        column: x => x.JobTicketId,
                        principalTable: "JobTicket",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_P2M_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "DisplayOrder", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(2024, 5, 20, 14, 5, 13, 129, DateTimeKind.Local).AddTicks(2022), "NEB", 1, "NEB", true },
                    { 2, "1", new DateTime(2024, 5, 20, 14, 5, 13, 129, DateTimeKind.Local).AddTicks(2038), "HSEB", 3, "HSEB", true },
                    { 3, "1", new DateTime(2024, 5, 20, 14, 5, 13, 129, DateTimeKind.Local).AddTicks(2039), "SLC", 2, "SLC", true }
                });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "Id", "Description", "FiscalYear", "Name", "status" },
                values: new object[,]
                {
                    { 1, null, null, "One", null },
                    { 2, null, null, "Two", null },
                    { 3, null, null, "Three", null }
                });

            migrationBuilder.InsertData(
                table: "DropdownV",
                columns: new[] { "Id", "Para", "ParaId", "ParaModel", "ParentParaId", "Remarks", "Status", "Value" },
                values: new object[,]
                {
                    { 1, "5", 1001, "PerPokaSize", 2001, "PerPokaSize", true, "5" },
                    { 2, "10", 1001, "PerPokaSize", 2001, "PerPokaSize", true, "10" },
                    { 3, "15", 1001, "PerPokaSize", 2001, "PerPokaSize", true, "15" },
                    { 4, "20", 1001, "PerPokaSize", 2001, "PerPokaSize", true, "20" },
                    { 5, "25", 1001, "PerPokaSize", 2001, "PerPokaSize", true, "25" },
                    { 6, "30", 1001, "PerPokaSize", 2001, "PerPokaSize", true, "30" },
                    { 7, "35", 1001, "PerPokaSize", 2001, "PerPokaSize", true, "35" },
                    { 8, "40", 1001, "PerPokaSize", 2001, "PerPokaSize", true, "40" },
                    { 9, "45", 1001, "PerPokaSize", 2001, "PerPokaSize", true, "45" },
                    { 10, "50", 1001, "PerPokaSize", 2001, "PerPokaSize", true, "50" },
                    { 11, "Male", 1002, "Gender", 2002, "Gender", true, "Male" },
                    { 12, "Female", 1002, "Gender", 2002, "Gender", true, "Female" },
                    { 13, "Others", 1002, "Gender", 2002, "Gender", true, "Others" }
                });

            migrationBuilder.InsertData(
                table: "FiscalYear",
                columns: new[] { "Id", "Description", "Name", "Status" },
                values: new object[,]
                {
                    { 1, null, "2080", null },
                    { 2, null, "2081", null },
                    { 3, null, "2082", null }
                });

            migrationBuilder.InsertData(
                table: "JobType",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Pre-Press" },
                    { 2, null, "Press" },
                    { 3, null, "Post-Press" }
                });

            migrationBuilder.InsertData(
                table: "Machinary",
                columns: new[] { "Id", "Description", "JobStep", "JobStepId", "Name", "Status" },
                values: new object[,]
                {
                    { 1, null, null, null, "Oliver ", null },
                    { 2, null, null, null, "RMGT", null },
                    { 3, null, null, null, "NaphA", null }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Description", "Name", "status" },
                values: new object[,]
                {
                    { 1, null, "Math", null },
                    { 2, null, "Science", null },
                    { 3, null, "Nepali", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "BasePrice", "CategoryId", "ClassId", "CostPrice", "CreatedBy", "Description", "FiscalYear", "FormaNumber", "ISBN", "ImageURL", "PageNumber", "Status", "SubjectId", "SubjectLanguageId", "SubjectLanguages", "SubjectTypeId", "SubjectTypes", "Title" },
                values: new object[,]
                {
                    { 1, "Author 1", 100.0, 1, 1, 50.0, "Admin", "Description 1", 2080, null, "ISBN-1", "http://example.com/product1.jpg", 100, true, 1, "1", null, "1", null, "Product 1" },
                    { 2, "Author 2", 200.0, 2, 2, 150.0, "Admin", "Description 2", 2081, null, "ISBN-2", "http://example.com/product2.jpg", 200, true, 2, "2", null, "2", null, "Product 2" },
                    { 3, "Author 1", 100.0, 1, 1, 50.0, "Admin", "Description 1", 2080, null, "ISBN-1", "http://example.com/product1.jpg", 100, true, 1, "1", null, "1", null, "Product 3" }
                });

            migrationBuilder.InsertData(
                table: "Forma",
                columns: new[] { "Id", "AssociatedFormaId", "Name", "Page", "PrintAchieved", "PrintTarget", "ProductId", "Remarks", "Status" },
                values: new object[,]
                {
                    { 1, null, "TA-32", null, null, null, 1, null, null },
                    { 2, null, "33-40", null, null, null, 1, null, null },
                    { 3, null, "41-51", null, null, null, 1, null, null },
                    { 4, null, "52-62", null, null, null, 1, null, null },
                    { 5, null, "64-93", null, null, null, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "JobTicket",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "DeletedBy", "Desc", "FiscalYearId", "JobCompleteDate", "JobDate", "JobStartDate", "JobStep", "JobStepId", "JobTypeId", "LotNumber", "Name", "PageNumber", "PrePrintSize", "PrintAchieved", "PrintTarget", "ProductId", "Remarks", "Status", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTimeOffset(new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 1", 1, new DateTimeOffset(new DateTime(2024, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step1", 1, 100, "Job 1", 1, 50, 950, 1000, 1, "Remarks 1", true, 1 },
                    { 2, null, 2, new DateTimeOffset(new DateTime(2024, 1, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 2", 2, new DateTimeOffset(new DateTime(2024, 1, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step2", 1, 101, "Job 2", 2, 100, 1900, 2000, 2, "Remarks 2", true, 2 },
                    { 3, null, 3, new DateTimeOffset(new DateTime(2024, 1, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 3", 3, new DateTimeOffset(new DateTime(2024, 1, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step3", 1, 102, "Job 3", 3, 150, 2850, 3000, 3, "Remarks 3", true, 3 },
                    { 4, null, 4, new DateTimeOffset(new DateTime(2024, 1, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 4", 1, new DateTimeOffset(new DateTime(2024, 1, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step4", 1, 103, "Job 4", 4, 200, 3800, 4000, 1, "Remarks 4", true, 4 },
                    { 5, null, 1, new DateTimeOffset(new DateTime(2024, 1, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 5", 2, new DateTimeOffset(new DateTime(2024, 1, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step5", 2, 104, "Job 5", 5, 250, 4750, 5000, 2, "Remarks 5", true, 1 },
                    { 6, null, 1, new DateTimeOffset(new DateTime(2024, 1, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 6", 3, new DateTimeOffset(new DateTime(2024, 1, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step6", 2, 105, "Job 6", 6, 300, 5700, 6000, 3, "Remarks 6", true, 2 },
                    { 7, null, 1, new DateTimeOffset(new DateTime(2024, 1, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 7", 1, new DateTimeOffset(new DateTime(2024, 1, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step7", 2, 106, "Job 7", 7, 350, 6650, 7000, 3, "Remarks 7", true, 1 },
                    { 8, null, 1, new DateTimeOffset(new DateTime(2024, 1, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 8", 2, new DateTimeOffset(new DateTime(2024, 1, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step8", 2, 107, "Job 8", 8, 400, 7600, 8000, 3, "Remarks 8", true, 2 },
                    { 9, null, 1, new DateTimeOffset(new DateTime(2024, 1, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 9", 3, new DateTimeOffset(new DateTime(2024, 1, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step9", 2, 108, "Job 9", 9, 450, 8550, 9000, 3, "Remarks 9", true, 1 }
                });

            migrationBuilder.InsertData(
                table: "MachineJobs",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Desc", "FiscalYear", "FormaId", "FormaPageSize", "FormaTarget", "InchargeId", "JobDate", "JobQuantity", "JobStep", "JobStepId", "JobTicketId", "JobTypeId", "MachinaryId", "Name", "OperatorId", "ProductId", "Remarks", "ReportDate", "Shift", "ShiftDuration", "ShiftDurationId", "ShiftId", "Status", "SupervisorId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 20, 8, 20, 13, 129, DateTimeKind.Utc).AddTicks(2301), "Description 1", null, 1, 10, null, 1, new DateTime(2024, 5, 20, 8, 20, 13, 129, DateTimeKind.Utc).AddTicks(2292), 10, null, "Step1", 1, 1, 1, "Machine Job 1", null, 1, "Remarks 1", new DateTime(2024, 5, 21, 8, 20, 13, 129, DateTimeKind.Utc).AddTicks(2292), null, null, "Duration1", "Shift1", true, 1, 1 },
                    { 2, 2, new DateTime(2024, 5, 20, 8, 20, 13, 129, DateTimeKind.Utc).AddTicks(2306), "Description 2", null, 2, 10, null, 2, new DateTime(2024, 5, 20, 8, 20, 13, 129, DateTimeKind.Utc).AddTicks(2304), 10, null, "Step2", 2, 2, 2, "Machine Job 2", null, 2, "Remarks 2", new DateTime(2024, 5, 22, 8, 20, 13, 129, DateTimeKind.Utc).AddTicks(2304), null, null, "Duration2", "Shift2", true, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Forma_ProductId",
                table: "Forma",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTicket_FiscalYearId",
                table: "JobTicket",
                column: "FiscalYearId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTicket_JobTypeId",
                table: "JobTicket",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTicket_ProductId",
                table: "JobTicket",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineJobs_FormaId",
                table: "MachineJobs",
                column: "FormaId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineJobs_JobTicketId",
                table: "MachineJobs",
                column: "JobTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineJobs_JobTypeId",
                table: "MachineJobs",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineJobs_MachinaryId",
                table: "MachineJobs",
                column: "MachinaryId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineJobs_ProductId",
                table: "MachineJobs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_P2M_ClassId",
                table: "P2M",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_P2M_DropdownVId",
                table: "P2M",
                column: "DropdownVId");

            migrationBuilder.CreateIndex(
                name: "IX_P2M_JobTicketId",
                table: "P2M",
                column: "JobTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_P2M_ProductId",
                table: "P2M",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ClassId",
                table: "Products",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubjectId",
                table: "Products",
                column: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MachineJobs");

            migrationBuilder.DropTable(
                name: "P2M");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Forma");

            migrationBuilder.DropTable(
                name: "Machinary");

            migrationBuilder.DropTable(
                name: "DropdownV");

            migrationBuilder.DropTable(
                name: "JobTicket");

            migrationBuilder.DropTable(
                name: "FiscalYear");

            migrationBuilder.DropTable(
                name: "JobType");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Subject");
        }
    }
}
