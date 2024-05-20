using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PackDB1909980 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "JobTicket",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 8, 34, 38, 656, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 8, 34, 38, 656, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 8, 34, 38, 656, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 5,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 6,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 7,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 8,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 9,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 20, 2, 49, 38, 656, DateTimeKind.Utc).AddTicks(7697), new DateTime(2024, 5, 20, 2, 49, 38, 656, DateTimeKind.Utc).AddTicks(7685), new DateTime(2024, 5, 21, 2, 49, 38, 656, DateTimeKind.Utc).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 20, 2, 49, 38, 656, DateTimeKind.Utc).AddTicks(7707), new DateTime(2024, 5, 20, 2, 49, 38, 656, DateTimeKind.Utc).AddTicks(7702), new DateTime(2024, 5, 22, 2, 49, 38, 656, DateTimeKind.Utc).AddTicks(7703) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "JobTicket");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 8, 23, 11, 690, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 8, 23, 11, 690, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 8, 23, 11, 690, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 20, 2, 38, 11, 691, DateTimeKind.Utc).AddTicks(348), new DateTime(2024, 5, 20, 2, 38, 11, 691, DateTimeKind.Utc).AddTicks(335), new DateTime(2024, 5, 21, 2, 38, 11, 691, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 20, 2, 38, 11, 691, DateTimeKind.Utc).AddTicks(359), new DateTime(2024, 5, 20, 2, 38, 11, 691, DateTimeKind.Utc).AddTicks(354), new DateTime(2024, 5, 22, 2, 38, 11, 691, DateTimeKind.Utc).AddTicks(355) });
        }
    }
}
