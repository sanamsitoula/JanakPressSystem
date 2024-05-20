using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PackDB190998 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DropdownVId",
                table: "P2M",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 8, 23, 11, 690, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 8, 23, 11, 690, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 8, 23, 11, 690, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.InsertData(
                table: "DropdownV",
                columns: new[] { "Id", "Para", "ParaId", "ParaModel", "ParentParaId", "Remarks", "Status", "Value" },
                values: new object[,]
                {
                    { 11, "Male", 1002, "Gender", 2002, "Gender", true, "Male" },
                    { 12, "Female", 1002, "Gender", 2002, "Gender", true, "Female" },
                    { 13, "Others", 1002, "Gender", 2002, "Gender", true, "Others" }
                });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 20, 2, 38, 11, 691, DateTimeKind.Utc).AddTicks(348), new DateTime(2024, 5, 20, 2, 38, 11, 691, DateTimeKind.Utc).AddTicks(335), new DateTime(2024, 5, 21, 2, 38, 11, 691, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 20, 2, 38, 11, 691, DateTimeKind.Utc).AddTicks(359), new DateTime(2024, 5, 20, 2, 38, 11, 691, DateTimeKind.Utc).AddTicks(354), new DateTime(2024, 5, 22, 2, 38, 11, 691, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.CreateIndex(
                name: "IX_P2M_DropdownVId",
                table: "P2M",
                column: "DropdownVId");

            migrationBuilder.AddForeignKey(
                name: "FK_P2M_DropdownV_DropdownVId",
                table: "P2M",
                column: "DropdownVId",
                principalTable: "DropdownV",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P2M_DropdownV_DropdownVId",
                table: "P2M");

            migrationBuilder.DropIndex(
                name: "IX_P2M_DropdownVId",
                table: "P2M");

            migrationBuilder.DeleteData(
                table: "DropdownV",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DropdownV",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DropdownV",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "DropdownVId",
                table: "P2M");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 7, 55, 35, 781, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 7, 55, 35, 781, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 7, 55, 35, 781, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 20, 2, 10, 35, 781, DateTimeKind.Utc).AddTicks(2370), new DateTime(2024, 5, 20, 2, 10, 35, 781, DateTimeKind.Utc).AddTicks(2359), new DateTime(2024, 5, 21, 2, 10, 35, 781, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 20, 2, 10, 35, 781, DateTimeKind.Utc).AddTicks(2387), new DateTime(2024, 5, 20, 2, 10, 35, 781, DateTimeKind.Utc).AddTicks(2376), new DateTime(2024, 5, 22, 2, 10, 35, 781, DateTimeKind.Utc).AddTicks(2377) });
        }
    }
}
