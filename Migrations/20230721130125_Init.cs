using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestApp.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StoreCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumber = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

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
                    { 1, new DateTime(2023, 7, 21, 16, 1, 25, 503, DateTimeKind.Local).AddTicks(1247), 1, "John", "Heart", "CEO", "Mr. " },
                    { 2, new DateTime(2023, 7, 21, 16, 1, 25, 503, DateTimeKind.Local).AddTicks(1292), 1, "Olivia", "Peyton", "Developer", "Mrs. " },
                    { 3, new DateTime(2023, 7, 21, 16, 1, 25, 503, DateTimeKind.Local).AddTicks(1295), 2, "Robert", "Reagan", "Manager", "Mr. " },
                    { 4, new DateTime(2023, 7, 21, 16, 1, 25, 503, DateTimeKind.Local).AddTicks(1298), 2, "Cynthia", "Stanvick", "TeamLead", "Mrs. " },
                    { 5, new DateTime(2023, 7, 21, 16, 1, 25, 503, DateTimeKind.Local).AddTicks(1300), 3, "Tim", "Cook", "CEO", "Mr. " },
                    { 6, new DateTime(2023, 7, 21, 16, 1, 25, 503, DateTimeKind.Local).AddTicks(1303), 3, "Adam", "Smith", "Developer", "Mr. " }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "OrderDate", "StoreCity" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 21, 16, 1, 25, 503, DateTimeKind.Local).AddTicks(1306), "Las Vegas" },
                    { 2, 1, new DateTime(2023, 7, 21, 16, 1, 25, 503, DateTimeKind.Local).AddTicks(1309), "Las Vegas" },
                    { 3, 2, new DateTime(2023, 7, 21, 16, 1, 25, 503, DateTimeKind.Local).AddTicks(1310), "San Jose" },
                    { 4, 2, new DateTime(2023, 7, 21, 16, 1, 25, 503, DateTimeKind.Local).AddTicks(1312), "San Jose" },
                    { 5, 3, new DateTime(2023, 7, 21, 16, 1, 25, 503, DateTimeKind.Local).AddTicks(1314), "Seattle" },
                    { 6, 3, new DateTime(2023, 7, 21, 16, 1, 25, 503, DateTimeKind.Local).AddTicks(1316), "Seattle" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CompanyId",
                table: "Employees",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_CompanyId",
                table: "Notes",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_EmployeeId",
                table: "Notes",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CompanyId",
                table: "Orders",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
