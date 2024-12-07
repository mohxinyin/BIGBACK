using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2024, 12, 8, 3, 46, 36, 798, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2024, 12, 8, 3, 46, 36, 798, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDateTime",
                value: new DateTime(2024, 12, 8, 3, 46, 36, 798, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDateTime",
                value: new DateTime(2024, 12, 8, 3, 46, 36, 798, DateTimeKind.Local).AddTicks(7633));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2024, 12, 8, 3, 44, 29, 616, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2024, 12, 8, 3, 44, 29, 616, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDateTime",
                value: new DateTime(2024, 12, 8, 3, 44, 29, 616, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDateTime",
                value: new DateTime(2024, 12, 8, 3, 44, 29, 616, DateTimeKind.Local).AddTicks(8961));
        }
    }
}
