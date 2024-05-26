using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class JPS14 : Migration
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
                value: new DateTime(2024, 5, 24, 11, 40, 11, 312, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 11, 40, 11, 312, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 11, 40, 11, 312, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 11, 40, 11, 312, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 11, 40, 11, 312, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 11, 40, 11, 312, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 11, 40, 11, 312, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 11, 40, 11, 312, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 11, 40, 11, 312, DateTimeKind.Local).AddTicks(6949));

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
                values: new object[] { new DateTime(2024, 5, 24, 5, 55, 11, 312, DateTimeKind.Utc).AddTicks(7215), new DateTime(2024, 5, 24, 5, 55, 11, 312, DateTimeKind.Utc).AddTicks(7205), new DateTime(2024, 5, 25, 5, 55, 11, 312, DateTimeKind.Utc).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 24, 5, 55, 11, 312, DateTimeKind.Utc).AddTicks(7220), new DateTime(2024, 5, 24, 5, 55, 11, 312, DateTimeKind.Utc).AddTicks(7217), new DateTime(2024, 5, 26, 5, 55, 11, 312, DateTimeKind.Utc).AddTicks(7218) });
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
                value: new DateTime(2024, 5, 24, 10, 20, 47, 985, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 10, 20, 47, 985, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 10, 20, 47, 985, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 10, 20, 47, 985, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 10, 20, 47, 985, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 10, 20, 47, 985, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 10, 20, 47, 985, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 10, 20, 47, 985, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 10, 20, 47, 985, DateTimeKind.Local).AddTicks(5265));

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
                values: new object[] { new DateTime(2024, 5, 24, 4, 35, 47, 985, DateTimeKind.Utc).AddTicks(5709), new DateTime(2024, 5, 24, 4, 35, 47, 985, DateTimeKind.Utc).AddTicks(5699), new DateTime(2024, 5, 25, 4, 35, 47, 985, DateTimeKind.Utc).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 24, 4, 35, 47, 985, DateTimeKind.Utc).AddTicks(5715), new DateTime(2024, 5, 24, 4, 35, 47, 985, DateTimeKind.Utc).AddTicks(5712), new DateTime(2024, 5, 26, 4, 35, 47, 985, DateTimeKind.Utc).AddTicks(5713) });
        }
    }
}
