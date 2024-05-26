using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _7855 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Class",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "Class",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 25, 11, 58, 24, 66, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 25, 11, 58, 24, 66, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 25, 11, 58, 24, 66, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 25, 11, 58, 24, 66, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 25, 11, 58, 24, 66, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 25, 11, 58, 24, 66, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 25, 11, 58, 24, 66, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 25, 11, 58, 24, 66, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 25, 11, 58, 24, 66, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "Value" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "Value" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Value" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 25, 6, 13, 24, 67, DateTimeKind.Utc).AddTicks(430), new DateTime(2024, 5, 25, 6, 13, 24, 67, DateTimeKind.Utc).AddTicks(417), new DateTime(2024, 5, 26, 6, 13, 24, 67, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 25, 6, 13, 24, 67, DateTimeKind.Utc).AddTicks(441), new DateTime(2024, 5, 25, 6, 13, 24, 67, DateTimeKind.Utc).AddTicks(436), new DateTime(2024, 5, 27, 6, 13, 24, 67, DateTimeKind.Utc).AddTicks(437) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Class");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 30, 54, 965, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 30, 54, 965, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 30, 54, 965, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 30, 54, 965, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 30, 54, 965, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 30, 54, 965, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 30, 54, 965, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 30, 54, 965, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 30, 54, 965, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 24, 15, 45, 54, 965, DateTimeKind.Utc).AddTicks(1835), new DateTime(2024, 5, 24, 15, 45, 54, 965, DateTimeKind.Utc).AddTicks(1827), new DateTime(2024, 5, 25, 15, 45, 54, 965, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 24, 15, 45, 54, 965, DateTimeKind.Utc).AddTicks(1841), new DateTime(2024, 5, 24, 15, 45, 54, 965, DateTimeKind.Utc).AddTicks(1838), new DateTime(2024, 5, 26, 15, 45, 54, 965, DateTimeKind.Utc).AddTicks(1838) });
        }
    }
}
