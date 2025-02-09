using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RiderId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c0e84a1-3aa8-4a51-a68b-04b352031fcd", "AQAAAAIAAYagAAAAEJ6YXK3dRPk5544JpwBL6Ead81ISOt3LDaOwXupZaidKpu/4BpqzN0VE34wTrg4eeA==", "45ba2f4b-6bd5-4cb4-a1c2-4379d35d07fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4781efa7-68dc-47f2-850f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74802d5f-9d44-4ca9-9fb7-62dfe086ef27", "AQAAAAIAAYagAAAAEHIbAqYq+/RUCGPiwsn3cbgXFaS1AFdBsJ7CxzDjQ6MyDHQSTnHT7MROdBz80kystw==", "38709284-51d9-4796-bb64-53944a020bfe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5781efa7-63dc-49f0-760f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a5c496f-18e7-42dc-a6f5-f187c78152dc", "AQAAAAIAAYagAAAAED5NmHxmwlRmB7mmADZaBKqSPshKur/BH/5k2jklxY/uCR3GR6oDIbY0pnDQUDVpGA==", "7438a17a-e331-4100-8737-0bd677feb9ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7651efa7-68dc-47f2-850f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "522a648d-450e-4e43-8012-9b9f2b360325", "AQAAAAIAAYagAAAAEFpPjR83MzptdAH6VwDp6f/nqA/cZ0n8T4dr0RYYuaUt+aJaxHV3amY3mdBYA3nWIA==", "367b087c-b749-4847-a7cb-bad9f74ffa59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7851efa7-69dc-47f2-890f-e507d04107e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4afcb522-6fd8-4123-a1d1-5c67588754cc", "AQAAAAIAAYagAAAAECyruDNLcPgjMjsj5C31JDYBomsI/9Hcm2NmWTUcTeBHXdtZ7ALLVarggl3i8aGZ2g==", "e4f45f20-e219-49f0-bce4-b49095f5d15d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8851efa7-69dc-49f2-790f-e506d04197e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32c6c989-439a-47ef-befe-3ca44e6bcab4", "AQAAAAIAAYagAAAAENQHjLeIwUkSldCHS58WY0HYtwL1IbDiqnYg1h2o6Zz6yr66KsZ9wdGODabKe80s5g==", "03920771-d290-450d-8b15-e483757cd715" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9781ifa7-63hc-48f0-700f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be2cb16b-7317-46f4-8ebe-26096c6cbedf", "AQAAAAIAAYagAAAAEFJQRR6JIMt5LPrUe1cpSeZp8VHuzTNX26F+VF1TgIja976mF5SC9duWq42pY/5YrA==", "2ec401b0-d449-4e7d-b9b7-7083c2b7cc46" });

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 1,
                column: "ComplaintDateTime",
                value: new DateTime(2025, 2, 8, 22, 15, 29, 451, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 2,
                column: "ComplaintDateTime",
                value: new DateTime(2025, 2, 8, 22, 15, 29, 451, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderDateTime", "RiderId", "StaffId" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 15, 29, 451, DateTimeKind.Local).AddTicks(7291), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderDateTime", "RiderId", "StaffId" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 15, 29, 451, DateTimeKind.Local).AddTicks(7309), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDateTime",
                value: new DateTime(2025, 2, 8, 22, 15, 29, 451, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDateTime",
                value: new DateTime(2025, 2, 8, 22, 15, 29, 451, DateTimeKind.Local).AddTicks(7457));

         
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.DropColumn(
                name: "RiderId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e966fd5-81d3-4f02-ab56-0cb8b646b779", "AQAAAAIAAYagAAAAELmoeTZNptbP1KpfVOVZlKsmCOpLvjkC/rCrPkquxzGMUnEFRAXcD0RBI05DSkSwcg==", "2480f685-efa6-4e1d-9937-2e1f297c09ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4781efa7-68dc-47f2-850f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0251905b-54d5-428d-8c5c-7bb325a35d30", "AQAAAAIAAYagAAAAEDEjFPfQjGLg3gGX9Thl1k3FAPFTTNVqWHlMrfSLtpTDKt8J1YzSL24iOX4jhH8XDw==", "b383c76b-ff79-43aa-b5fa-15135e158ff0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5781efa7-63dc-49f0-760f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2244f61e-a5c9-4b1a-b4a8-3ddb2301c6f1", "AQAAAAIAAYagAAAAED8EOPepgYwY9Ub04c48bWFrpjxzBAyzl6pbCsTCM1Oj+l0RQoRHdzxCYbhYVFqemw==", "323c5563-fbdd-4d22-827a-a888eca767d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7651efa7-68dc-47f2-850f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b729a205-bf5d-4e8d-8671-cbeab66f1d52", "AQAAAAIAAYagAAAAEJiZ51E5Cesq4tiS0RTKMVJ7yAn47HA+3KtwMtbn5zeRGlL5THQPQzfeSwh7MFYT9A==", "73751b24-a35f-4f65-b98d-383c7d53a4fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7851efa7-69dc-47f2-890f-e507d04107e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1b5f76a-d4a3-464d-88fa-efbccf131d54", "AQAAAAIAAYagAAAAEJ67srvp3a0jcvMhZMefGbEeQkGWPqdWKqsfHGQcJljiW4nJ5PchHleZszXkgtiLLw==", "a65f88e3-8160-4b6d-a9c4-fe359a08dab5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8851efa7-69dc-49f2-790f-e506d04197e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89c20ecf-e314-4647-88e9-a868fb0f2998", "AQAAAAIAAYagAAAAEGQG+QwPOyBoNjaGbT0IT3wq8ooBfyqn/cum+pz4wf08q9xOy2UyXas93FurCy0mWg==", "93769ae6-24d3-44e1-bdf2-b3b484fed5e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9781ifa7-63hc-48f0-700f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3eb569b-372e-427f-9352-a276cc96207c", "AQAAAAIAAYagAAAAEIp2owF/s6ZL4GFcXZvHfigsgfET4S1HlWa6382Kjc0TDD7Z9ekqlygpBqVAHmfxkA==", "63f20adf-c840-4535-af19-b01171968c76" });

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 1,
                column: "ComplaintDateTime",
                value: new DateTime(2025, 2, 5, 23, 41, 28, 991, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 2,
                column: "ComplaintDateTime",
                value: new DateTime(2025, 2, 5, 23, 41, 28, 991, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2025, 2, 5, 23, 41, 28, 991, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2025, 2, 5, 23, 41, 28, 991, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDateTime",
                value: new DateTime(2025, 2, 5, 23, 41, 28, 991, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDateTime",
                value: new DateTime(2025, 2, 5, 23, 41, 28, 991, DateTimeKind.Local).AddTicks(6940));
        }
    }
}
