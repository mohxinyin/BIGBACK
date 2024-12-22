using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "162dc310-005c-4915-aeff-126f578be5a8", "AQAAAAIAAYagAAAAEHM5Bix3h0aH03UtTFsyQK8xMfaXN90rTewL2VwOX7lWN5q9G4L+HzfLuRQpMkdsuA==", "79d39c05-8ea7-4867-87e5-d5ab026c5402" });

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 1,
                column: "ComplaintDateTime",
                value: new DateTime(2024, 12, 22, 22, 31, 43, 456, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 2,
                column: "ComplaintDateTime",
                value: new DateTime(2024, 12, 22, 22, 31, 43, 456, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2024, 12, 22, 22, 31, 43, 455, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2024, 12, 22, 22, 31, 43, 455, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDateTime",
                value: new DateTime(2024, 12, 22, 22, 31, 43, 455, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDateTime",
                value: new DateTime(2024, 12, 22, 22, 31, 43, 455, DateTimeKind.Local).AddTicks(9886));
        }
    }
}
