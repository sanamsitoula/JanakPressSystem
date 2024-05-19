using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialDBPMSFiscForma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormaNumber",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 12, 32, 9, 732, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 12, 32, 9, 732, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 12, 32, 9, 732, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 6, 47, 9, 732, DateTimeKind.Utc).AddTicks(7869), new DateTime(2024, 5, 19, 6, 47, 9, 732, DateTimeKind.Utc).AddTicks(7859), new DateTime(2024, 5, 20, 6, 47, 9, 732, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 6, 47, 9, 732, DateTimeKind.Utc).AddTicks(7875), new DateTime(2024, 5, 19, 6, 47, 9, 732, DateTimeKind.Utc).AddTicks(7872), new DateTime(2024, 5, 21, 6, 47, 9, 732, DateTimeKind.Utc).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "FormaNumber",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "FormaNumber",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "FormaNumber",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormaNumber",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 11, 17, 44, 219, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 11, 17, 44, 219, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 11, 17, 44, 219, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 5, 32, 44, 219, DateTimeKind.Utc).AddTicks(9868), new DateTime(2024, 5, 19, 5, 32, 44, 219, DateTimeKind.Utc).AddTicks(9858), new DateTime(2024, 5, 20, 5, 32, 44, 219, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "MachineJobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "JobDate", "ReportDate" },
                values: new object[] { new DateTime(2024, 5, 19, 5, 32, 44, 219, DateTimeKind.Utc).AddTicks(9872), new DateTime(2024, 5, 19, 5, 32, 44, 219, DateTimeKind.Utc).AddTicks(9870), new DateTime(2024, 5, 21, 5, 32, 44, 219, DateTimeKind.Utc).AddTicks(9871) });
        }
    }
}
