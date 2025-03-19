using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 20, 48, 272, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 20, 48, 282, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 20, 48, 282, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 20, 48, 282, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 20, 48, 282, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 20, 48, 282, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 20, 48, 282, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 20, 48, 282, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 20, 48, 282, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2025, 3, 17, 15, 35, 48, 283, DateTimeKind.Utc).AddTicks(3720), new DateTime(2025, 3, 17, 15, 35, 48, 283, DateTimeKind.Utc).AddTicks(2620), new DateTime(2025, 3, 18, 15, 35, 48, 283, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2025, 3, 17, 15, 35, 48, 283, DateTimeKind.Utc).AddTicks(4370), new DateTime(2025, 3, 17, 15, 35, 48, 283, DateTimeKind.Utc).AddTicks(4370), new DateTime(2025, 3, 19, 15, 35, 48, 283, DateTimeKind.Utc).AddTicks(4370) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 16, 51, 530, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 21, 16, 51, 539, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2025, 3, 17, 15, 31, 51, 540, DateTimeKind.Utc).AddTicks(7920), new DateTime(2025, 3, 17, 15, 31, 51, 540, DateTimeKind.Utc).AddTicks(6820), new DateTime(2025, 3, 18, 15, 31, 51, 540, DateTimeKind.Utc).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2025, 3, 17, 15, 31, 51, 540, DateTimeKind.Utc).AddTicks(8570), new DateTime(2025, 3, 17, 15, 31, 51, 540, DateTimeKind.Utc).AddTicks(8560), new DateTime(2025, 3, 19, 15, 31, 51, 540, DateTimeKind.Utc).AddTicks(8570) });
        }
    }
}
