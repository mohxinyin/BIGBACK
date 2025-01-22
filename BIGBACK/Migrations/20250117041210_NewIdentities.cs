using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class NewIdentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cd2bcf0c-20db-474f-8407-5a6b159518ba", null, "BusinessOwner", "BUSINESSOWNER" },
                    { "dd2bcf0c-20db-474f-8407-5a6b159518bb", null, "Rider", "RIDER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24d7b3ad-c6fe-4694-a28c-ec0382d0b981", "AQAAAAIAAYagAAAAEBhJYqCPHLdwR+79EJ/kkxwlvDMyyHi25nxy1SukooaMq3dNeNO/xI/l82n2cVgXHA==", "9dde12cb-b6fd-489c-9397-3436e75cfd52" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4781efa7-68dc-47f2-850f-e506d04102e4", 0, "a37995b1-8e4e-480e-9f37-9bc33a3d78a5", "business_annaBakery@localhost.com", true, "Anna", "Businessowner", false, null, "BUSINESS_ANNABAKERY@LOCALHOST.COM", "BUSINESS_ANNABAKERY@LOCALHOST.COM", "AQAAAAIAAYagAAAAEKIIy6CDhLV8rbXuVHQIh25NhQsL6Vnh2FXyzdyr469h5OzdobrTHHixvqyFVfh99Q==", null, false, "ca619504-78e5-4201-9635-18bc846dcf10", false, "business_annaBakery@localhost.com" },
                    { "5781efa7-63dc-49f0-760f-e506d04102e4", 0, "81c0c536-5632-446a-924b-5cb54372093d", "rider_charlie@localhost.com", true, "Charlie", "Brown", false, null, "RIDER_CHARLIE@LOCALHOST.COM", "RIDER_CHARLIE@LOCALHOST.COM", "AQAAAAIAAYagAAAAENgdpMHSbs1AhoQekmCc5PwX7HbiNtSUTeIH3MfCdDu6WEdqMccA3wVIFHwimYY3Dg==", null, false, "8f414f24-2e21-4764-a8aa-0ee9d093d68e", false, "rider_charlie@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cd2bcf0c-20db-474f-8407-5a6b159518ba", "4781efa7-68dc-47f2-850f-e506d04102e4" },
                    { "dd2bcf0c-20db-474f-8407-5a6b159518bb", "5781efa7-63dc-49f0-760f-e506d04102e4" }
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cd2bcf0c-20db-474f-8407-5a6b159518ba", "4781efa7-68dc-47f2-850f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dd2bcf0c-20db-474f-8407-5a6b159518bb", "5781efa7-63dc-49f0-760f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4781efa7-68dc-47f2-850f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5781efa7-63dc-49f0-760f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94ea59b7-7f2f-4e50-bccd-9ff994b523a5", "AQAAAAIAAYagAAAAEOnhgtWHXxx2Cj4+sUdUSlg+IyAjIw75J9d5I/NAbOzk+g4musNJ67y2MRd8Mrc93Q==", "f5ec4cd8-e8d9-47af-855e-6ee96efe5500" });

        }
    }
}