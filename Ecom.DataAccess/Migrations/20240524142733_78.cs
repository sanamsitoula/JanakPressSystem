using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _78 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JobStepId",
                table: "Machinary",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                table: "Machinary",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobStepId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machinary",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobStepId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machinary",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobStepId",
                value: null);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "JobStepId",
                table: "Machinary",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                table: "Machinary",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobStepId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machinary",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobStepId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machinary",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobStepId",
                value: null);

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
        }
    }
}
