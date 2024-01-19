using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Razor_Temp.Migrations
{
    /// <inheritdoc />
    public partial class AddCategorytoDB : Migration
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
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "DisplayOrder", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(2024, 1, 8, 13, 10, 21, 940, DateTimeKind.Local).AddTicks(7238), "Action", 1, "Action", true },
                    { 2, "1", new DateTime(2024, 1, 8, 13, 10, 21, 940, DateTimeKind.Local).AddTicks(7251), "Tamil", 3, "Tamil", true },
                    { 3, "1", new DateTime(2024, 1, 8, 13, 10, 21, 940, DateTimeKind.Local).AddTicks(7252), "Animation", 2, "Animation", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
