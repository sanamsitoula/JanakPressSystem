using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DB5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 14, 56, 1, 664, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 14, 56, 1, 664, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 14, 56, 1, 664, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 14, 56, 1, 664, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 14, 56, 1, 664, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 14, 56, 1, 664, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 14, 56, 1, 664, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 14, 56, 1, 664, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 14, 56, 1, 664, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 30, 9, 11, 1, 664, DateTimeKind.Utc).AddTicks(1008), new DateTime(2024, 5, 30, 9, 11, 1, 664, DateTimeKind.Utc).AddTicks(991), new DateTime(2024, 5, 31, 9, 11, 1, 664, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 30, 9, 11, 1, 664, DateTimeKind.Utc).AddTicks(1014), new DateTime(2024, 5, 30, 9, 11, 1, 664, DateTimeKind.Utc).AddTicks(1011), new DateTime(2024, 6, 1, 9, 11, 1, 664, DateTimeKind.Utc).AddTicks(1012) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 18, 28, 21, 305, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 18, 28, 21, 305, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 18, 28, 21, 305, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 18, 28, 21, 305, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 18, 28, 21, 305, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 18, 28, 21, 305, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 18, 28, 21, 305, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 18, 28, 21, 305, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 18, 28, 21, 305, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 43, 21, 305, DateTimeKind.Utc).AddTicks(8856), new DateTime(2024, 5, 26, 12, 43, 21, 305, DateTimeKind.Utc).AddTicks(8840), new DateTime(2024, 5, 27, 12, 43, 21, 305, DateTimeKind.Utc).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 43, 21, 305, DateTimeKind.Utc).AddTicks(8866), new DateTime(2024, 5, 26, 12, 43, 21, 305, DateTimeKind.Utc).AddTicks(8862), new DateTime(2024, 5, 28, 12, 43, 21, 305, DateTimeKind.Utc).AddTicks(8863) });
        }
    }
}
