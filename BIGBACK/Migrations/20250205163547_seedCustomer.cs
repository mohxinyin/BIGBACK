using System;
using Microsoft.EntityFrameworkCore.Migrations;
#nullable disable
#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional
namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class seedCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            // ✅ Insert Data should be OUTSIDE the constraints block
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CustomerAddress", "CustomerEmail", "CustomerGender", "CustomerMobileNumber", "CustomerName", "CreatedBy", "UpdatedBy", "DateCreated", "DateUpdated" },
                values: new object[,]
                {
                    { 1, "3 AngMoKio Ave", "johndoe1@gmail.com", "Male", "91062378", "John Doe", "7851efa7-69dc-47f2-890f-e507d04107e4", "7851efa7-69dc-47f2-890f-e507d04107e4", DateTime.UtcNow, DateTime.UtcNow },
                    { 2, "3 Yishun Ave", "maryjane2@gmail.com", "Female", "91054379", "Mary Jane", "8851efa7-69dc-49f2-790f-e506d04197e4", "8851efa7-69dc-49f2-790f-e506d04197e4", DateTime.UtcNow, DateTime.UtcNow }
                });
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);
        }

    }
}