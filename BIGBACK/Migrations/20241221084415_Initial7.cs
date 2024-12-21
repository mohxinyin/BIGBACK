using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class Initial7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 1,
                column: "ComplaintDateTime",
                value: new DateTime(2024, 12, 21, 16, 44, 14, 660, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 2,
                column: "ComplaintDateTime",
                value: new DateTime(2024, 12, 21, 16, 44, 14, 660, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2024, 12, 21, 16, 44, 14, 660, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2024, 12, 21, 16, 44, 14, 660, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDateTime",
                value: new DateTime(2024, 12, 21, 16, 44, 14, 660, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDateTime",
                value: new DateTime(2024, 12, 21, 16, 44, 14, 660, DateTimeKind.Local).AddTicks(5000));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 1,
                column: "ComplaintDateTime",
                value: new DateTime(2024, 12, 21, 16, 40, 8, 272, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 2,
                column: "ComplaintDateTime",
                value: new DateTime(2024, 12, 21, 16, 40, 8, 272, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2024, 12, 21, 16, 40, 8, 272, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2024, 12, 21, 16, 40, 8, 272, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDateTime",
                value: new DateTime(2024, 12, 21, 16, 40, 8, 272, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDateTime",
                value: new DateTime(2024, 12, 21, 16, 40, 8, 272, DateTimeKind.Local).AddTicks(5533));
        }
    }
}
