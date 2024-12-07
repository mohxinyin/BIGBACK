using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CustomerAddress", "CustomerEmail", "CustomerGender", "CustomerID", "CustomerMobileNumber", "CustomerName" },
                values: new object[,]
                {
                    { 1, "3 AngMoKio Ave", "johndoe1@gmail.com", "Male", null, "91062378", "John Doe" },
                    { 2, "3 Yishun Ave", "maryjane2@gmail.com", "Female", null, "91054379", "Mary Jane" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CustomerId", "OrderDateTime", "OrderStatus", "OrderTotal" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 7, 15, 34, 41, 258, DateTimeKind.Local).AddTicks(1282), "Pending", 64.50m },
                    { 2, 2, new DateTime(2024, 12, 7, 15, 34, 41, 258, DateTimeKind.Local).AddTicks(1304), "Pending", 55.70m }
                });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "Id", "MenuItemId", "OrderId", "OrderItemPromo", "OrderItemQty" },
                values: new object[,]
                {
                    { 1, 1, 1, null, 1 },
                    { 2, 2, 2, "NEWCUSTOMER25", 2 }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "OrderId", "PaymentAmount", "PaymentDateTime", "PaymentMethod", "PaymentStatus" },
                values: new object[,]
                {
                    { 1, 1, 64.50m, new DateTime(2024, 12, 7, 15, 34, 41, 258, DateTimeKind.Local).AddTicks(1475), "VISA Debit", "Completed" },
                    { 2, 2, 55.70m, new DateTime(2024, 12, 7, 15, 34, 41, 258, DateTimeKind.Local).AddTicks(1478), "PayNow", "Completed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
