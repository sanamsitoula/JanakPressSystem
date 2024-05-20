using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PackDB190 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormaNumber",
                table: "P2M",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobTicketId",
                table: "P2M",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 7, 55, 35, 781, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 7, 55, 35, 781, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 20, 7, 55, 35, 781, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 20, 2, 10, 35, 781, DateTimeKind.Utc).AddTicks(2370), new DateTime(2024, 5, 20, 2, 10, 35, 781, DateTimeKind.Utc).AddTicks(2359), new DateTime(2024, 5, 21, 2, 10, 35, 781, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 20, 2, 10, 35, 781, DateTimeKind.Utc).AddTicks(2387), new DateTime(2024, 5, 20, 2, 10, 35, 781, DateTimeKind.Utc).AddTicks(2376), new DateTime(2024, 5, 22, 2, 10, 35, 781, DateTimeKind.Utc).AddTicks(2377) });

            migrationBuilder.CreateIndex(
                name: "IX_P2M_JobTicketId",
                table: "P2M",
                column: "JobTicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_P2M_JobTicket_JobTicketId",
                table: "P2M",
                column: "JobTicketId",
                principalTable: "JobTicket",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P2M_JobTicket_JobTicketId",
                table: "P2M");

            migrationBuilder.DropIndex(
                name: "IX_P2M_JobTicketId",
                table: "P2M");

            migrationBuilder.DropColumn(
                name: "FormaNumber",
                table: "P2M");

            migrationBuilder.DropColumn(
                name: "JobTicketId",
                table: "P2M");

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
    }
}
