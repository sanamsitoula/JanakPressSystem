using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DBM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "P2M",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 20, 27, 0, 519, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 20, 27, 0, 519, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 20, 27, 0, 519, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 20, 27, 0, 519, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 20, 27, 0, 519, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 20, 27, 0, 519, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 20, 27, 0, 519, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 20, 27, 0, 519, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 20, 27, 0, 519, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 1,
                column: "NoofAssociatedForma",
                value: 10);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 2,
                column: "NoofAssociatedForma",
                value: 10);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 3,
                column: "NoofAssociatedForma",
                value: 10);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 4,
                column: "NoofAssociatedForma",
                value: 10);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 5,
                column: "NoofAssociatedForma",
                value: 10);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 6,
                column: "NoofAssociatedForma",
                value: 10);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 7,
                column: "NoofAssociatedForma",
                value: 10);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 8,
                column: "NoofAssociatedForma",
                value: 10);

            migrationBuilder.UpdateData(
                table: "JobTicket",
                keyColumn: "Id",
                keyValue: 9,
                column: "NoofAssociatedForma",
                value: 10);

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 42, 0, 519, DateTimeKind.Utc).AddTicks(7786), new DateTime(2024, 5, 22, 14, 42, 0, 519, DateTimeKind.Utc).AddTicks(7777), new DateTime(2024, 5, 23, 14, 42, 0, 519, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 42, 0, 519, DateTimeKind.Utc).AddTicks(7792), new DateTime(2024, 5, 22, 14, 42, 0, 519, DateTimeKind.Utc).AddTicks(7789), new DateTime(2024, 5, 24, 14, 42, 0, 519, DateTimeKind.Utc).AddTicks(7790) });

            migrationBuilder.CreateIndex(
                name: "IX_P2M_SubjectId",
                table: "P2M",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_P2M_Subject_SubjectId",
                table: "P2M",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P2M_Subject_SubjectId",
                table: "P2M");

            migrationBuilder.DropIndex(
                name: "IX_P2M_SubjectId",
                table: "P2M");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "P2M");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 25, 52, 109, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 25, 52, 109, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 25, 52, 109, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 25, 52, 109, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 25, 52, 109, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 25, 52, 109, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 25, 52, 109, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 25, 52, 109, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 22, 25, 52, 109, DateTimeKind.Local).AddTicks(876));

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
                values: new object[] { new DateTime(2024, 5, 21, 16, 40, 52, 109, DateTimeKind.Utc).AddTicks(1399), new DateTime(2024, 5, 21, 16, 40, 52, 109, DateTimeKind.Utc).AddTicks(1385), new DateTime(2024, 5, 22, 16, 40, 52, 109, DateTimeKind.Utc).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 40, 52, 109, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 5, 21, 16, 40, 52, 109, DateTimeKind.Utc).AddTicks(1405), new DateTime(2024, 5, 23, 16, 40, 52, 109, DateTimeKind.Utc).AddTicks(1406) });
        }
    }
}
