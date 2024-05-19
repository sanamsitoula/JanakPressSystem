using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EcomDev1113 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 23, 24, 50, 985, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 23, 24, 50, 985, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 23, 24, 50, 985, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 17, 39, 50, 985, DateTimeKind.Utc).AddTicks(6604), new DateTime(2024, 5, 19, 17, 39, 50, 985, DateTimeKind.Utc).AddTicks(6596), new DateTime(2024, 5, 20, 17, 39, 50, 985, DateTimeKind.Utc).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 17, 39, 50, 985, DateTimeKind.Utc).AddTicks(6610), new DateTime(2024, 5, 19, 17, 39, 50, 985, DateTimeKind.Utc).AddTicks(6607), new DateTime(2024, 5, 21, 17, 39, 50, 985, DateTimeKind.Utc).AddTicks(6608) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 23, 1, 27, 592, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 23, 1, 27, 592, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 23, 1, 27, 592, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 17, 16, 27, 593, DateTimeKind.Utc).AddTicks(42), new DateTime(2024, 5, 19, 17, 16, 27, 593, DateTimeKind.Utc).AddTicks(32), new DateTime(2024, 5, 20, 17, 16, 27, 593, DateTimeKind.Utc).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 17, 16, 27, 593, DateTimeKind.Utc).AddTicks(48), new DateTime(2024, 5, 19, 17, 16, 27, 593, DateTimeKind.Utc).AddTicks(46), new DateTime(2024, 5, 21, 17, 16, 27, 593, DateTimeKind.Utc).AddTicks(46) });
        }
    }
}
