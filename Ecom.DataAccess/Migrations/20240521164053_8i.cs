using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _8i : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Forma",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Page", "PrintTarget" },
                values: new object[] { 32, 205000 });

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 2,
                column: "PrintTarget",
                value: 205000);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 3,
                column: "PrintTarget",
                value: 205000);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 4,
                column: "PrintTarget",
                value: 205000);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "PrintTarget", "ProductId" },
                values: new object[] { "TA-62", 205000, 2 });

            migrationBuilder.InsertData(
                table: "Forma",
                columns: new[] { "Id", "AssociatedFormaId", "Name", "Page", "PrintAchieved", "PrintTarget", "ProductId", "Remarks", "Status" },
                values: new object[,]
                {
                    { 6, null, "33-40", null, null, 205000, 2, null, null },
                    { 7, null, "41-51", null, null, 205000, 2, null, null },
                    { 8, null, "52-62", null, null, 205000, 3, null, null },
                    { 9, null, "64-93", 32, null, 205000, 3, null, null }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 21, 5, 1, 774, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 21, 5, 1, 774, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 21, 5, 1, 774, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 21, 5, 1, 774, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 21, 5, 1, 774, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 21, 5, 1, 774, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 21, 5, 1, 774, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 21, 5, 1, 774, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 21, 5, 1, 774, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Page", "PrintTarget" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 2,
                column: "PrintTarget",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 3,
                column: "PrintTarget",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 4,
                column: "PrintTarget",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "PrintTarget", "ProductId" },
                values: new object[] { "64-93", null, 1 });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 1, 774, DateTimeKind.Utc).AddTicks(479), new DateTime(2024, 5, 21, 15, 20, 1, 774, DateTimeKind.Utc).AddTicks(470), new DateTime(2024, 5, 22, 15, 20, 1, 774, DateTimeKind.Utc).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 1, 774, DateTimeKind.Utc).AddTicks(486), new DateTime(2024, 5, 21, 15, 20, 1, 774, DateTimeKind.Utc).AddTicks(483), new DateTime(2024, 5, 23, 15, 20, 1, 774, DateTimeKind.Utc).AddTicks(483) });
        }
    }
}
