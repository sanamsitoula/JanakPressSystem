using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _781 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Forma",
                type: "nvarchar(max)",
                nullable: true);

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
                table: "Forma",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 5,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 6,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 7,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 8,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 9,
                column: "Code",
                value: null);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Forma");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 20, 12, 31, 593, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 20, 12, 31, 593, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 20, 12, 31, 593, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 20, 12, 31, 593, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 20, 12, 31, 593, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 20, 12, 31, 593, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 20, 12, 31, 593, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 20, 12, 31, 593, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 20, 12, 31, 593, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 24, 14, 27, 31, 593, DateTimeKind.Utc).AddTicks(7181), new DateTime(2024, 5, 24, 14, 27, 31, 593, DateTimeKind.Utc).AddTicks(7169), new DateTime(2024, 5, 25, 14, 27, 31, 593, DateTimeKind.Utc).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 24, 14, 27, 31, 593, DateTimeKind.Utc).AddTicks(7192), new DateTime(2024, 5, 24, 14, 27, 31, 593, DateTimeKind.Utc).AddTicks(7187), new DateTime(2024, 5, 26, 14, 27, 31, 593, DateTimeKind.Utc).AddTicks(7188) });
        }
    }
}
