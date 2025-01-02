using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class Initial8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "StaffID",
                table: "Complaint",
                newName: "StaffId");

            migrationBuilder.RenameColumn(
                name: "RiderID",
                table: "Complaint",
                newName: "RiderId");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Complaint",
                newName: "OrderId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b24b9cc3-f40a-4096-b8da-2976b1a7ebc6", "AQAAAAIAAYagAAAAEKQAxmkK4KnK0/kziASrDisIQI6AynNAZ4OctVq5ntETKw9CL+zz7go8uHXOx7E7dw==", "b8158f51-169c-4af4-98f6-e837f8c5ef60" });

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 1,
                column: "ComplaintDateTime",
                value: new DateTime(2024, 12, 31, 16, 57, 53, 754, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 2,
                column: "ComplaintDateTime",
                value: new DateTime(2024, 12, 31, 16, 57, 53, 754, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2024, 12, 31, 16, 57, 53, 754, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2024, 12, 31, 16, 57, 53, 754, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDateTime",
                value: new DateTime(2024, 12, 31, 16, 57, 53, 754, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDateTime",
                value: new DateTime(2024, 12, 31, 16, 57, 53, 754, DateTimeKind.Local).AddTicks(5655));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "Complaint",
                newName: "StaffID");

            migrationBuilder.RenameColumn(
                name: "RiderId",
                table: "Complaint",
                newName: "RiderID");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Complaint",
                newName: "OrderID");

            migrationBuilder.AddColumn<string>(
                name: "CustomerID",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "757d69a1-b2d3-4e09-96ef-6321856b7d55", "AQAAAAIAAYagAAAAELnq3J1RC/yxgFDiJ29TwkqcJUvuD5jefUiCPcKKk86LleJyud1vpp4l+Gy3LMHUoA==", "9d7866c1-666c-4788-82ad-9c936284d9ff" });

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 1,
                column: "ComplaintDateTime",
                value: new DateTime(2024, 12, 22, 22, 39, 59, 718, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 2,
                column: "ComplaintDateTime",
                value: new DateTime(2024, 12, 22, 22, 39, 59, 718, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "CustomerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "CustomerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2024, 12, 22, 22, 39, 59, 718, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2024, 12, 22, 22, 39, 59, 718, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDateTime",
                value: new DateTime(2024, 12, 22, 22, 39, 59, 718, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDateTime",
                value: new DateTime(2024, 12, 22, 22, 39, 59, 718, DateTimeKind.Local).AddTicks(9193));
        }
    }
}
