using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Mac : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FormaId",
                table: "MachineJobs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "JobQuantity",
                table: "MachineJobs",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 21, 34, 12, 369, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 21, 34, 12, 369, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 21, 34, 12, 369, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "JobQuantity", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 18, 15, 49, 12, 370, DateTimeKind.Utc).AddTicks(202), new DateTime(2024, 5, 18, 15, 49, 12, 370, DateTimeKind.Utc).AddTicks(194), null, new DateTime(2024, 5, 19, 15, 49, 12, 370, DateTimeKind.Utc).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "JobQuantity", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 18, 15, 49, 12, 370, DateTimeKind.Utc).AddTicks(209), new DateTime(2024, 5, 18, 15, 49, 12, 370, DateTimeKind.Utc).AddTicks(206), null, new DateTime(2024, 5, 20, 15, 49, 12, 370, DateTimeKind.Utc).AddTicks(207) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobQuantity",
                table: "MachineJobs");

            migrationBuilder.AlterColumn<int>(
                name: "FormaId",
                table: "MachineJobs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 14, 1, 15, 120, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 14, 1, 15, 120, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 14, 1, 15, 120, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 18, 8, 16, 15, 120, DateTimeKind.Utc).AddTicks(5231), new DateTime(2024, 5, 18, 8, 16, 15, 120, DateTimeKind.Utc).AddTicks(5221), new DateTime(2024, 5, 19, 8, 16, 15, 120, DateTimeKind.Utc).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 18, 8, 16, 15, 120, DateTimeKind.Utc).AddTicks(5237), new DateTime(2024, 5, 18, 8, 16, 15, 120, DateTimeKind.Utc).AddTicks(5234), new DateTime(2024, 5, 20, 8, 16, 15, 120, DateTimeKind.Utc).AddTicks(5235) });
        }
    }
}
