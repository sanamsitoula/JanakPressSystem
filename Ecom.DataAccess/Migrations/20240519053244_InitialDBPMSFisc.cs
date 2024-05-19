using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialDBPMSFisc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FiscalYear",
                table: "MachineJobs",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 11, 17, 44, 219, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 11, 17, 44, 219, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 11, 17, 44, 219, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FiscalYear", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 5, 32, 44, 219, DateTimeKind.Utc).AddTicks(9868), null, new DateTime(2024, 5, 19, 5, 32, 44, 219, DateTimeKind.Utc).AddTicks(9858), new DateTime(2024, 5, 20, 5, 32, 44, 219, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FiscalYear", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 5, 32, 44, 219, DateTimeKind.Utc).AddTicks(9872), null, new DateTime(2024, 5, 19, 5, 32, 44, 219, DateTimeKind.Utc).AddTicks(9870), new DateTime(2024, 5, 21, 5, 32, 44, 219, DateTimeKind.Utc).AddTicks(9871) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FiscalYear",
                table: "MachineJobs");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 10, 31, 1, 92, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 10, 31, 1, 92, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 10, 31, 1, 92, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 4, 46, 1, 92, DateTimeKind.Utc).AddTicks(7140), new DateTime(2024, 5, 19, 4, 46, 1, 92, DateTimeKind.Utc).AddTicks(7131), new DateTime(2024, 5, 20, 4, 46, 1, 92, DateTimeKind.Utc).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 4, 46, 1, 92, DateTimeKind.Utc).AddTicks(7144), new DateTime(2024, 5, 19, 4, 46, 1, 92, DateTimeKind.Utc).AddTicks(7142), new DateTime(2024, 5, 21, 4, 46, 1, 92, DateTimeKind.Utc).AddTicks(7143) });
        }
    }
}
