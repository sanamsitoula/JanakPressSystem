using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MachineJobAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OperatorId",
                table: "MachineJobs",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 8, 49, 40, 564, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 8, 49, 40, 564, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 8, 49, 40, 564, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "OperatorId", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 3, 4, 40, 564, DateTimeKind.Utc).AddTicks(766), new DateTime(2024, 5, 19, 3, 4, 40, 564, DateTimeKind.Utc).AddTicks(753), null, new DateTime(2024, 5, 20, 3, 4, 40, 564, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "OperatorId", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 3, 4, 40, 564, DateTimeKind.Utc).AddTicks(779), new DateTime(2024, 5, 19, 3, 4, 40, 564, DateTimeKind.Utc).AddTicks(773), null, new DateTime(2024, 5, 21, 3, 4, 40, 564, DateTimeKind.Utc).AddTicks(774) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OperatorId",
                table: "MachineJobs");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 22, 48, 11, 873, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 22, 48, 11, 873, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 22, 48, 11, 873, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 18, 17, 3, 11, 873, DateTimeKind.Utc).AddTicks(8667), new DateTime(2024, 5, 18, 17, 3, 11, 873, DateTimeKind.Utc).AddTicks(8654), new DateTime(2024, 5, 19, 17, 3, 11, 873, DateTimeKind.Utc).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 18, 17, 3, 11, 873, DateTimeKind.Utc).AddTicks(8679), new DateTime(2024, 5, 18, 17, 3, 11, 873, DateTimeKind.Utc).AddTicks(8674), new DateTime(2024, 5, 20, 17, 3, 11, 873, DateTimeKind.Utc).AddTicks(8675) });
        }
    }
}
