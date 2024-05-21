using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EcomMachJob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NoofAssociatedForma",
                table: "JobTicket",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 20, 5, 9, 318, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 20, 5, 9, 318, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 20, 5, 9, 318, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 1,
                column: "NoofAssociatedForma",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 2,
                column: "NoofAssociatedForma",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 3,
                column: "NoofAssociatedForma",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 4,
                column: "NoofAssociatedForma",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 5,
                column: "NoofAssociatedForma",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 6,
                column: "NoofAssociatedForma",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 7,
                column: "NoofAssociatedForma",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 8,
                column: "NoofAssociatedForma",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 9,
                column: "NoofAssociatedForma",
                value: null);

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 20, 14, 20, 9, 318, DateTimeKind.Utc).AddTicks(8678), new DateTime(2024, 5, 20, 14, 20, 9, 318, DateTimeKind.Utc).AddTicks(8665), new DateTime(2024, 5, 21, 14, 20, 9, 318, DateTimeKind.Utc).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 20, 14, 20, 9, 318, DateTimeKind.Utc).AddTicks(8688), new DateTime(2024, 5, 20, 14, 20, 9, 318, DateTimeKind.Utc).AddTicks(8683), new DateTime(2024, 5, 22, 14, 20, 9, 318, DateTimeKind.Utc).AddTicks(8684) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoofAssociatedForma",
                table: "JobTicket");

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
    }
}
