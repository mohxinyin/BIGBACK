using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f710b691-26c3-44c0-b709-11fa83d87cfc", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIfGmxXRNB6/bF84Q6EOsTbdnk8iMP4hhj5dd0ZT3aeL/8t1WFrM9lmJtKWL6y1nRQ==", null, false, "927effd6-6fbe-4235-afd3-35eb9a5aefeb", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });


            //migrationBuilder.UpdateData(
            //        table: "AspNetUsers",
            //        keyColumn: "Id",
            //        keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
            //        columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //        values: new object[] { "915eb6d9-e97e-434b-a5d6-51fa99882f08", "AQAAAAIAAYagAAAAEAOb5MQYPVQc/AxZwmhYmTx/BGaH+YfYvMC2Ar5noAODbNb0LyWqjeVBt+8JrAguGg==", "1ec47347-292c-4595-b337-b46006545770" });

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 1,
                column: "ComplaintDateTime",
                value: new DateTime(2025, 1, 2, 12, 22, 17, 664, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 2,
                column: "ComplaintDateTime",
                value: new DateTime(2025, 1, 2, 12, 22, 17, 664, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2025, 1, 2, 12, 22, 17, 664, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2025, 1, 2, 12, 22, 17, 664, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDateTime",
                value: new DateTime(2025, 1, 2, 12, 22, 17, 664, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDateTime",
                value: new DateTime(2025, 1, 2, 12, 22, 17, 664, DateTimeKind.Local).AddTicks(644));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                 table: "AspNetRoles",
                 keyColumn: "Id",
                 keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");


            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "fe14e5fd-85a2-4d4d-b647-21ac6324d378", "AQAAAAIAAYagAAAAEGTIhfapaLJIF9C3tosA7Bw0Kqs8sHV3j/jF/vdqTpaYI9XV5jsMdlznKjU4yD4ZOg==", "9a3a4346-cad6-44bc-8ce5-39480beb2a42" });

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 1,
                column: "ComplaintDateTime",
                value: new DateTime(2025, 1, 2, 12, 2, 58, 34, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 2,
                column: "ComplaintDateTime",
                value: new DateTime(2025, 1, 2, 12, 2, 58, 34, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2025, 1, 2, 12, 2, 58, 34, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2025, 1, 2, 12, 2, 58, 34, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDateTime",
                value: new DateTime(2025, 1, 2, 12, 2, 58, 34, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDateTime",
                value: new DateTime(2025, 1, 2, 12, 2, 58, 34, DateTimeKind.Local).AddTicks(7468));
        }
    }
}
