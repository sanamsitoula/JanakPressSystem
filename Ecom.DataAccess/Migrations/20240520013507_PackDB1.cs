using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PackDB1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReportDate",
                table: "P2M",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "P2MDate",
                table: "P2M",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 7, 20, 6, 565, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 7, 20, 6, 565, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 7, 20, 6, 565, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 20, 1, 35, 6, 565, DateTimeKind.Utc).AddTicks(8708), new DateTime(2024, 5, 20, 1, 35, 6, 565, DateTimeKind.Utc).AddTicks(8696), new DateTime(2024, 5, 21, 1, 35, 6, 565, DateTimeKind.Utc).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 20, 1, 35, 6, 565, DateTimeKind.Utc).AddTicks(8720), new DateTime(2024, 5, 20, 1, 35, 6, 565, DateTimeKind.Utc).AddTicks(8715), new DateTime(2024, 5, 22, 1, 35, 6, 565, DateTimeKind.Utc).AddTicks(8716) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReportDate",
                table: "P2M",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "P2MDate",
                table: "P2M",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
