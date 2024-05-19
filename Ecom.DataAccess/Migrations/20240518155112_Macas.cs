using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Macas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Page",
                table: "MachineJobs",
                newName: "FormaPageSize");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 21, 36, 11, 494, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 21, 36, 11, 494, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 21, 36, 11, 494, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "JobQuantity", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 18, 15, 51, 11, 494, DateTimeKind.Utc).AddTicks(7612), new DateTime(2024, 5, 18, 15, 51, 11, 494, DateTimeKind.Utc).AddTicks(7603), 10, new DateTime(2024, 5, 19, 15, 51, 11, 494, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FormaPageSize", "JobDate", "JobQuantity", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 18, 15, 51, 11, 494, DateTimeKind.Utc).AddTicks(7619), 10, new DateTime(2024, 5, 18, 15, 51, 11, 494, DateTimeKind.Utc).AddTicks(7616), 10, new DateTime(2024, 5, 20, 15, 51, 11, 494, DateTimeKind.Utc).AddTicks(7617) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FormaPageSize",
                table: "MachineJobs",
                newName: "Page");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 21, 34, 12, 369, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 21, 34, 12, 369, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 21, 34, 12, 369, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "JobQuantity", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 18, 15, 49, 12, 370, DateTimeKind.Utc).AddTicks(202), new DateTime(2024, 5, 18, 15, 49, 12, 370, DateTimeKind.Utc).AddTicks(194), null, new DateTime(2024, 5, 19, 15, 49, 12, 370, DateTimeKind.Utc).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "JobQuantity", "Page", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 18, 15, 49, 12, 370, DateTimeKind.Utc).AddTicks(209), new DateTime(2024, 5, 18, 15, 49, 12, 370, DateTimeKind.Utc).AddTicks(206), null, 20, new DateTime(2024, 5, 20, 15, 49, 12, 370, DateTimeKind.Utc).AddTicks(207) });
        }
    }
}
