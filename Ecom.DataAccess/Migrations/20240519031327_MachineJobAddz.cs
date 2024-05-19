using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MachineJobAddz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MachinaryId",
                table: "MachineJobs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 8, 58, 26, 494, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 8, 58, 26, 494, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 8, 58, 26, 494, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 3, 13, 26, 494, DateTimeKind.Utc).AddTicks(6547), new DateTime(2024, 5, 19, 3, 13, 26, 494, DateTimeKind.Utc).AddTicks(6536), new DateTime(2024, 5, 20, 3, 13, 26, 494, DateTimeKind.Utc).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 3, 13, 26, 494, DateTimeKind.Utc).AddTicks(6560), new DateTime(2024, 5, 19, 3, 13, 26, 494, DateTimeKind.Utc).AddTicks(6554), new DateTime(2024, 5, 21, 3, 13, 26, 494, DateTimeKind.Utc).AddTicks(6555) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MachinaryId",
                table: "MachineJobs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 8, 49, 40, 564, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 8, 49, 40, 564, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 8, 49, 40, 564, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 3, 4, 40, 564, DateTimeKind.Utc).AddTicks(766), new DateTime(2024, 5, 19, 3, 4, 40, 564, DateTimeKind.Utc).AddTicks(753), new DateTime(2024, 5, 20, 3, 4, 40, 564, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 3, 4, 40, 564, DateTimeKind.Utc).AddTicks(779), new DateTime(2024, 5, 19, 3, 4, 40, 564, DateTimeKind.Utc).AddTicks(773), new DateTime(2024, 5, 21, 3, 4, 40, 564, DateTimeKind.Utc).AddTicks(774) });
        }
    }
}
