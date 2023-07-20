using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 7, 20, 21, 2, 21, 203, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2023, 7, 20, 21, 2, 21, 203, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 7, 20, 21, 2, 21, 203, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2023, 7, 20, 21, 2, 21, 203, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2023, 7, 20, 21, 2, 21, 203, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2023, 7, 20, 21, 2, 21, 203, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 7, 20, 21, 2, 21, 203, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 7, 20, 21, 2, 21, 203, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2023, 7, 20, 21, 2, 21, 203, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2023, 7, 20, 21, 2, 21, 203, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2023, 7, 20, 21, 2, 21, 203, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2023, 7, 20, 21, 2, 21, 203, DateTimeKind.Local).AddTicks(2136));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6984));
        }
    }
}
