using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(21)", maxLength: 21, nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    EmployeeID = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    dob = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<bool>(type: "boolean", nullable: true),
                    FiscalYear = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DropdownV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Para = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    ParaModel = table.Column<string>(type: "text", nullable: true),
                    ParaId = table.Column<int>(type: "integer", nullable: true),
                    ParentParaId = table.Column<int>(type: "integer", nullable: true),
                    Remarks = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DropdownV", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FiscalYear",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiscalYear", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Machinary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: true),
                    JobStepId = table.Column<string>(type: "text", nullable: true),
                    JobStep = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machinary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ISBN = table.Column<string>(type: "text", nullable: true),
                    Author = table.Column<string>(type: "text", nullable: true),
                    BasePrice = table.Column<double>(type: "double precision", nullable: true),
                    CostPrice = table.Column<double>(type: "double precision", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<int>(type: "integer", nullable: true),
                    ImageURL = table.Column<string>(type: "text", nullable: true),
                    FiscalYear = table.Column<int>(type: "integer", nullable: true),
                    PageNumber = table.Column<int>(type: "integer", nullable: true),
                    SubjectId = table.Column<int>(type: "integer", nullable: true),
                    ClassId = table.Column<int>(type: "integer", nullable: true),
                    FormaNumber = table.Column<int>(type: "integer", nullable: true),
                    SubjectLanguageId = table.Column<string>(type: "text", nullable: true),
                    SubjectLanguages = table.Column<int>(type: "integer", nullable: true),
                    SubjectTypeId = table.Column<string>(type: "text", nullable: true),
                    SubjectTypes = table.Column<int>(type: "integer", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Page = table.Column<int>(type: "integer", nullable: true),
                    PrintTarget = table.Column<int>(type: "integer", nullable: true),
                    PrintAchieved = table.Column<int>(type: "integer", nullable: true),
                    AssociatedFormaId = table.Column<string>(type: "text", nullable: true),
                    Remarks = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: true),
                    PageNumber = table.Column<int>(type: "integer", nullable: true),
                    PrintTarget = table.Column<int>(type: "integer", nullable: true),
                    JobDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    JobStartDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    JobCompleteDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    LotNumber = table.Column<int>(type: "integer", nullable: true),
                    JobTypeId = table.Column<int>(type: "integer", nullable: false),
                    PrintAchieved = table.Column<int>(type: "integer", nullable: true),
                    Desc = table.Column<string>(type: "text", nullable: true),
                    Remarks = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    DeletedBy = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    FiscalYearId = table.Column<int>(type: "integer", nullable: true),
                    PrePrintSize = table.Column<int>(type: "integer", nullable: true),
                    JobStepId = table.Column<string>(type: "text", nullable: true),
                    JobStep = table.Column<int>(type: "integer", nullable: true),
                    NoofAssociatedForma = table.Column<int>(type: "integer", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    JobTicketId = table.Column<int>(type: "integer", nullable: false),
                    MachinaryId = table.Column<int>(type: "integer", nullable: false),
                    FormaId = table.Column<int>(type: "integer", nullable: false),
                    JobDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ReportDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FormaPageSize = table.Column<int>(type: "integer", nullable: true),
                    JobQuantity = table.Column<int>(type: "integer", nullable: true),
                    FormaTarget = table.Column<int>(type: "integer", nullable: true),
                    JobTypeId = table.Column<int>(type: "integer", nullable: false),
                    JobStepId = table.Column<string>(type: "text", nullable: true),
                    JobStep = table.Column<int>(type: "integer", nullable: true),
                    ShiftId = table.Column<string>(type: "text", nullable: true),
                    Shift = table.Column<int>(type: "integer", nullable: true),
                    ShiftDurationId = table.Column<string>(type: "text", nullable: true),
                    ShiftDuration = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    Desc = table.Column<string>(type: "text", nullable: true),
                    Remarks = table.Column<string>(type: "text", nullable: true),
                    SupervisorId = table.Column<int>(type: "integer", nullable: true),
                    InchargeId = table.Column<int>(type: "integer", nullable: true),
                    OperatorId = table.Column<int>(type: "integer", nullable: true),
                    FiscalYear = table.Column<int>(type: "integer", nullable: true),
                    JobTicketTarget = table.Column<int>(type: "integer", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    P2M_Code = table.Column<string>(type: "text", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: true),
                    ClassId = table.Column<int>(type: "integer", nullable: false),
                    P2MDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ReportDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    JobTicketId = table.Column<int>(type: "integer", nullable: true),
                    FormaNumber = table.Column<int>(type: "integer", nullable: true),
                    PerPokaSize = table.Column<int>(type: "integer", nullable: true),
                    DropdownVId = table.Column<int>(type: "integer", nullable: true),
                    PokaNumber = table.Column<int>(type: "integer", nullable: true),
                    ProductQuantity = table.Column<int>(type: "integer", nullable: true),
                    PiecesQuantity = table.Column<int>(type: "integer", nullable: true),
                    TotalProductQuantity = table.Column<int>(type: "integer", nullable: true),
                    JobStepId = table.Column<string>(type: "text", nullable: true),
                    JobStep = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    Desc = table.Column<string>(type: "text", nullable: true),
                    Remarks = table.Column<string>(type: "text", nullable: true),
                    CheckedById = table.Column<int>(type: "integer", nullable: true),
                    VerifiedById = table.Column<int>(type: "integer", nullable: true),
                    ReceivedById = table.Column<int>(type: "integer", nullable: true),
                    FiscalYear = table.Column<int>(type: "integer", nullable: true),
                    SubjectId = table.Column<int>(type: "integer", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_P2M_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "DisplayOrder", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(2025, 3, 17, 21, 16, 51, 530, DateTimeKind.Local).AddTicks(2120), "NEB", 1, "NEB", true },
                    { 2, "1", new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8500), "HSEB", 3, "HSEB", true },
                    { 3, "1", new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8510), "SLC", 3, "SLC", true },
                    { 4, "1", new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8510), "Book", 3, "Book", true },
                    { 5, "1", new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8520), "Exercise Book", 3, "Exercise Book", true },
                    { 6, "1", new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8520), "Jhura Kagaj", 3, "Jhura Kagaj", true },
                    { 7, "1", new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8520), "Kawadi", 3, "Kawadi", true },
                    { 8, "1", new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8520), "Religious", 3, "Religious", true },
                    { 9, "1", new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8520), "Election", 2, "Election", true }
                });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "Id", "Code", "Description", "FiscalYear", "Name", "Value", "status" },
                values: new object[,]
                {
                    { 1, null, null, null, "One", null, null },
                    { 2, null, null, null, "Two", null, null },
                    { 3, null, null, null, "Three", null, null }
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
                columns: new[] { "Id", "AssociatedFormaId", "Code", "Name", "Page", "PrintAchieved", "PrintTarget", "ProductId", "Remarks", "Status" },
                values: new object[,]
                {
                    { 1, null, null, "TA-32", 32, null, 205000, 1, null, null },
                    { 2, null, null, "33-40", null, null, 205000, 1, null, null },
                    { 3, null, null, "41-51", null, null, 205000, 1, null, null },
                    { 4, null, null, "52-62", null, null, 205000, 1, null, null },
                    { 5, null, null, "TA-62", null, null, 205000, 2, null, null },
                    { 6, null, null, "33-40", null, null, 205000, 2, null, null },
                    { 7, null, null, "41-51", null, null, 205000, 2, null, null },
                    { 8, null, null, "52-62", null, null, 205000, 3, null, null },
                    { 9, null, null, "64-93", 32, null, 205000, 3, null, null }
                });

            migrationBuilder.InsertData(
                table: "JobTicket",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "DeletedBy", "Desc", "FiscalYearId", "JobCompleteDate", "JobDate", "JobStartDate", "JobStep", "JobStepId", "JobTypeId", "LotNumber", "Name", "NoofAssociatedForma", "PageNumber", "PrePrintSize", "PrintAchieved", "PrintTarget", "ProductId", "Remarks", "Status", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTimeOffset(new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 1", 1, new DateTimeOffset(new DateTime(2024, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step1", 1, 100, "Job 1", 10, 1, 50, 950, 1000, 1, "Remarks 1", true, 1 },
                    { 2, null, 2, new DateTimeOffset(new DateTime(2024, 1, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 2", 2, new DateTimeOffset(new DateTime(2024, 1, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step2", 1, 101, "Job 2", 10, 2, 100, 1900, 2000, 2, "Remarks 2", true, 2 },
                    { 3, null, 3, new DateTimeOffset(new DateTime(2024, 1, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 3", 3, new DateTimeOffset(new DateTime(2024, 1, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step3", 1, 102, "Job 3", 10, 3, 150, 2850, 3000, 3, "Remarks 3", true, 3 },
                    { 4, null, 4, new DateTimeOffset(new DateTime(2024, 1, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 4", 1, new DateTimeOffset(new DateTime(2024, 1, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step4", 1, 103, "Job 4", 10, 4, 200, 3800, 4000, 1, "Remarks 4", true, 4 },
                    { 5, null, 1, new DateTimeOffset(new DateTime(2024, 1, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 5", 2, new DateTimeOffset(new DateTime(2024, 1, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step5", 2, 104, "Job 5", 10, 5, 250, 4750, 5000, 2, "Remarks 5", true, 1 },
                    { 6, null, 1, new DateTimeOffset(new DateTime(2024, 1, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 6", 3, new DateTimeOffset(new DateTime(2024, 1, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step6", 2, 105, "Job 6", 10, 6, 300, 5700, 6000, 3, "Remarks 6", true, 2 },
                    { 7, null, 1, new DateTimeOffset(new DateTime(2024, 1, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 7", 1, new DateTimeOffset(new DateTime(2024, 1, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step7", 2, 106, "Job 7", 10, 7, 350, 6650, 7000, 3, "Remarks 7", true, 1 },
                    { 8, null, 1, new DateTimeOffset(new DateTime(2024, 1, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 8", 2, new DateTimeOffset(new DateTime(2024, 1, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step8", 2, 107, "Job 8", 10, 8, 400, 7600, 8000, 3, "Remarks 8", true, 2 },
                    { 9, null, 1, new DateTimeOffset(new DateTime(2024, 1, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Description 9", 3, new DateTimeOffset(new DateTime(2024, 1, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Step9", 2, 108, "Job 9", 10, 9, 450, 8550, 9000, 3, "Remarks 9", true, 1 }
                });

            migrationBuilder.InsertData(
                table: "MachineJobs",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Desc", "FiscalYear", "FormaId", "FormaPageSize", "FormaTarget", "InchargeId", "JobDate", "JobQuantity", "JobStep", "JobStepId", "JobTicketId", "JobTicketTarget", "JobTypeId", "MachinaryId", "Name", "OperatorId", "ProductId", "Remarks", "ReportDate", "Shift", "ShiftDuration", "ShiftDurationId", "ShiftId", "Status", "SupervisorId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 3, 17, 15, 31, 51, 540, DateTimeKind.Utc).AddTicks(7920), "Description 1", null, 1, 10, null, 1, new DateTime(2025, 3, 17, 15, 31, 51, 540, DateTimeKind.Utc).AddTicks(6820), 10, null, "Step1", 1, null, 1, 1, "Machine Job 1", null, 1, "Remarks 1", new DateTime(2025, 3, 18, 15, 31, 51, 540, DateTimeKind.Utc).AddTicks(6950), null, null, "Duration1", "Shift1", true, 1, 1 },
                    { 2, 2, new DateTime(2025, 3, 17, 15, 31, 51, 540, DateTimeKind.Utc).AddTicks(8570), "Description 2", null, 2, 10, null, 2, new DateTime(2025, 3, 17, 15, 31, 51, 540, DateTimeKind.Utc).AddTicks(8560), 10, null, "Step2", 2, null, 2, 2, "Machine Job 2", null, 2, "Remarks 2", new DateTime(2025, 3, 19, 15, 31, 51, 540, DateTimeKind.Utc).AddTicks(8570), null, null, "Duration2", "Shift2", true, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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
                name: "IX_P2M_SubjectId",
                table: "P2M",
                column: "SubjectId");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MachineJobs");

            migrationBuilder.DropTable(
                name: "P2M");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
