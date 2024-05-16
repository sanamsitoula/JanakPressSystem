using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FormaDatasedd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forma_Products_ProductId",
                table: "Forma");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Forma",
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
                value: new DateTime(2024, 5, 16, 19, 13, 34, 943, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 19, 13, 34, 943, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 19, 13, 34, 943, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Forma_Products_ProductId",
                table: "Forma",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forma_Products_ProductId",
                table: "Forma");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Forma",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 44, 1, 181, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 44, 1, 181, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 16, 44, 1, 181, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forma",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Forma_Products_ProductId",
                table: "Forma",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
