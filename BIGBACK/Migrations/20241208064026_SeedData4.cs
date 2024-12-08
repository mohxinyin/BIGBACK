using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class SeedData4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Complaint",
            columns: new[] { "Id", "OrderID", "StaffID", "RiderID", "ComplaintDesc", "ComplaintStatus", "ComplaintDateTime" },
            values: new object[,]
            {
            { 1, 1, 1, 1, "Late delivery", "Open", new DateTime(2024, 12, 9) },
            { 2, 2, 2, 2, "Damaged item", "Resolved", new DateTime(2024, 12, 8) }
        });

            migrationBuilder.InsertData(
            table: "Delivery",
            columns: new[] { "Id", "DeliveryDate", "DeliveryTime", "CustomerID", "OrderID", "BusinessID", "DeliveryFee", "DeliveryStatus" },
            values: new object[,]
            {
            { 1, new DateTime(2024, 12, 8), new DateTime(2024, 12, 8, 10, 30, 0), 1, 1, 1, 5.99m, "Pending" },
            { 2, new DateTime(2024, 12, 9), new DateTime(2024, 12, 9, 15, 45, 0), 2, 2, 1, 7.49m, "Delivered" }
        });
            migrationBuilder.InsertData(
            table: "DeliveryRider",
            columns: new[] { "Id", "DeliveryRiderTaskType", "DeliveryRiderStatus", "DeliveryId", "RiderId" },
            values: new object[,]
            {
            { 1, "Pickup", "Assigned", 1, 1 },
            { 2, "Drop-off", "In Transit", 2, 2 }
        });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 2);

            // Delete data from DeliveryRider table
            migrationBuilder.DeleteData(
                table: "DeliveryRider",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeliveryRider",
                keyColumn: "Id",
                keyValue: 2);

            // Delete data from Delivery table
            migrationBuilder.DeleteData(
                table: "Delivery",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Delivery",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
