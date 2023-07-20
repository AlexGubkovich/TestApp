using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "City", "Name", "Phone", "State" },
                values: new object[,]
                {
                    { 1, "702 8th Street", "Atlanta", "Super Mart of the West", "(800) 555-55-99", "Georgia" },
                    { 2, "702 8th Street", "Dallas", "Electronic Deport", "(900) 556-33-33", "Texas" },
                    { 3, "702 8th Street", "Bentonville", "ElectricMax", "(763) 888-00-11", "Arkansas" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "CompanyId", "FirstName", "LastName", "Position", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6912), 1, "John", "Heart", "CEO", "Mr. " },
                    { 2, new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6960), 1, "Olivia", "Peyton", "Developer", "Mrs. " },
                    { 3, new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6963), 2, "Robert", "Reagan", "Manager", "Mr. " },
                    { 4, new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6965), 2, "Cynthia", "Stanvick", "TeamLead", "Mrs. " },
                    { 5, new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6967), 3, "Tim", "Cook", "CEO", "Mr. " },
                    { 6, new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6970), 3, "Adam", "Smith", "Developer", "Mr. " }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "OrderDate", "StoreCity" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6974), "Las Vegas" },
                    { 2, 1, new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6977), "Las Vegas" },
                    { 3, 2, new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6979), "San Jose" },
                    { 4, 2, new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6980), "San Jose" },
                    { 5, 3, new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6982), "Seattle" },
                    { 6, 3, new DateTime(2023, 7, 20, 20, 3, 58, 67, DateTimeKind.Local).AddTicks(6984), "Seattle" }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "CompanyId", "EmployeeId", "InvoiceNumber" },
                values: new object[,]
                {
                    { 1, 1, 1, 100 },
                    { 2, 1, 2, 101 },
                    { 3, 2, 3, 102 },
                    { 4, 2, 4, 103 },
                    { 5, 3, 5, 104 },
                    { 6, 3, 6, 105 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
