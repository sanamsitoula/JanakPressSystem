using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Macasd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormaTarget",
                table: "MachineJobs",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 22, 48, 11, 873, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 22, 48, 11, 873, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 22, 48, 11, 873, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FormaTarget", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 18, 17, 3, 11, 873, DateTimeKind.Utc).AddTicks(8667), null, new DateTime(2024, 5, 18, 17, 3, 11, 873, DateTimeKind.Utc).AddTicks(8654), new DateTime(2024, 5, 19, 17, 3, 11, 873, DateTimeKind.Utc).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FormaTarget", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 18, 17, 3, 11, 873, DateTimeKind.Utc).AddTicks(8679), null, new DateTime(2024, 5, 18, 17, 3, 11, 873, DateTimeKind.Utc).AddTicks(8674), new DateTime(2024, 5, 20, 17, 3, 11, 873, DateTimeKind.Utc).AddTicks(8675) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormaTarget",
                table: "MachineJobs");

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
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 18, 15, 51, 11, 494, DateTimeKind.Utc).AddTicks(7612), new DateTime(2024, 5, 18, 15, 51, 11, 494, DateTimeKind.Utc).AddTicks(7603), new DateTime(2024, 5, 19, 15, 51, 11, 494, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 18, 15, 51, 11, 494, DateTimeKind.Utc).AddTicks(7619), new DateTime(2024, 5, 18, 15, 51, 11, 494, DateTimeKind.Utc).AddTicks(7616), new DateTime(2024, 5, 20, 15, 51, 11, 494, DateTimeKind.Utc).AddTicks(7617) });
        }
    }
}
