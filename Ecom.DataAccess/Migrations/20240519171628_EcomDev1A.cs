using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EcomDev1A : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecievedById",
                table: "P2M",
                newName: "ReceivedById");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReceivedById",
                table: "P2M",
                newName: "RecievedById");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 22, 8, 4, 508, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 22, 8, 4, 508, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 22, 8, 4, 508, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 16, 23, 4, 508, DateTimeKind.Utc).AddTicks(6713), new DateTime(2024, 5, 19, 16, 23, 4, 508, DateTimeKind.Utc).AddTicks(6705), new DateTime(2024, 5, 20, 16, 23, 4, 508, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 16, 23, 4, 508, DateTimeKind.Utc).AddTicks(6719), new DateTime(2024, 5, 19, 16, 23, 4, 508, DateTimeKind.Utc).AddTicks(6717), new DateTime(2024, 5, 21, 16, 23, 4, 508, DateTimeKind.Utc).AddTicks(6717) });
        }
    }
}
