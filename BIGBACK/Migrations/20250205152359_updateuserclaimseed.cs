using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class updateuserclaimseed : Migration
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
                    CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "nvarchar(max)", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });


            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9d8f424-660a-4b0c-858c-820c7b15beb9", "AQAAAAIAAYagAAAAECqBHW91EPrJOfSfDw0q9sar3KkptU902VkCjE8iKXEnH5+z2uQKwthaodxGsX2EMA==", "eb467717-acda-40c2-8f75-1a9089b7ccfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4781efa7-68dc-47f2-850f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "001e3e06-d98c-45d5-8955-1ac4767e8e36", "AQAAAAIAAYagAAAAEOgFTocJKNeumPgkIhU76oYCyrCnIixHltSZ8kOyv1TDsU4zXsZfTAgwxNnzUaqquA==", "a4bde66f-b759-4b16-af3e-f5b20b1e4f82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5781efa7-63dc-49f0-760f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e39ed1c7-8ae9-4efb-b582-abbdeb47300f", "AQAAAAIAAYagAAAAEFx7ofWE5ioOquGYHOjZiL9qZsMPGKlbF0mtxJXfbPQzN7Xa9gwfMog4dfaHm6kuaA==", "532b862e-1637-43ac-8cd3-c6389cf5d3cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7651efa7-68dc-47f2-850f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0eb13ba-275e-458a-b541-af52826d32f9", "AQAAAAIAAYagAAAAEIcYeRdh8s/B4J4OjGAc4ALYBne79ujIrpbEbEH6UFtYVxBKACoscrQqtinWtO/G/w==", "19e1fb16-b721-4e86-8804-2127efe1ccac" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7851efa7-69dc-47f2-890f-e507d04107e4", 0, "3db1d0dd-9b98-43b3-a896-5e5964388df6", "johndoe1@gmail.com", true, "John", "Doe", false, null, "JOHNDOE1@GMAIL.COM", "JOHNDOE1@GMAIL.COM", "AQAAAAIAAYagAAAAEGnCx4OS46ZU/qPlB+yZTUGNYlYOcW5cuccw05w0gVAggClAL3FCJ3QmFb5gL6ZoGA==", null, false, "9ca9562b-5244-4936-a298-1b65a57cb20f", false, "johndoe1@gmail.com" },
                    { "8851efa7-69dc-49f2-790f-e506d04197e4", 0, "d6466bab-1544-440d-a3f6-42f9a6277237", "maryjane2@gmail.com", true, "Mary", "Jane", false, null, "MARYJANE2@GMAIL.COM", "MARYJANE2@GMAIL.COM", "AQAAAAIAAYagAAAAEHpSSPmXQPHr9dZwwQsZhUkGhuzD9dt49wIBxjx9dwq/wMYKKuD+zR1xEXgLFO+XsA==", null, false, "53402ad2-b2fd-40ac-890c-88dc832688e9", false, "maryjane2@gmail.com" },
                    { "9781ifa7-63hc-48f0-700f-e506d04102e4", 0, "54597d13-e2bc-4614-b354-36845b181992", "rider_daisylee@localhost.com", true, "Daisy", "Lee", false, null, "RIDER_DAISYLEE@LOCALHOST.COM", "RIDER_DAISYLEE@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAAaQ3bW+mbia4rdKSOI5ueHuN9TiX+KR6w0tL7KY2I7Ilt/l4WTBanKEYaGTVCCZg==", null, false, "42e7a3a6-13d7-43e9-bdc2-1eaecf0fff81", false, "rider_daisylee@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "BusinessOwner",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { "4781efa7-68dc-47f2-850f-e506d04102e4", "4781efa7-68dc-47f2-850f-e506d04102e4" });

            migrationBuilder.UpdateData(
                table: "BusinessOwner",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { "7651efa7-68dc-47f2-850f-e506d04102e4", "7651efa7-68dc-47f2-850f-e506d04102e4" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { "7851efa7-69dc-47f2-890f-e507d04107e4", "7851efa7-69dc-47f2-890f-e507d04107e4" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { "8851efa7-69dc-49f2-790f-e506d04197e4", "8851efa7-69dc-49f2-790f-e506d04197e4" });


            migrationBuilder.UpdateData(
                table: "Rider",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { "5781efa7-63dc-49f0-760f-e506d04102e4", "5781efa7-63dc-49f0-760f-e506d04102e4" });

            migrationBuilder.UpdateData(
                table: "Rider",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { "9781ifa7-63hc-48f0-700f-e506d04102e4", "9781ifa7-63hc-48f0-700f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "7851efa7-69dc-47f2-890f-e507d04107e4" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "8851efa7-69dc-49f2-790f-e506d04197e4" },
                    { "dd2bcf0c-20db-474f-8407-5a6b159518bb", "9781ifa7-63hc-48f0-700f-e506d04102e4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "7851efa7-69dc-47f2-890f-e507d04107e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "8851efa7-69dc-49f2-790f-e506d04197e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dd2bcf0c-20db-474f-8407-5a6b159518bb", "9781ifa7-63hc-48f0-700f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7851efa7-69dc-47f2-890f-e507d04107e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8851efa7-69dc-49f2-790f-e506d04197e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9781ifa7-63hc-48f0-700f-e506d04102e4");






            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a688754c-c5db-41ae-bc61-95cd9d665ead", "AQAAAAIAAYagAAAAEPB7LoS2UUvn3CCihoNN0QtG8F3/UMFsrjOfWy6EWk5PGkTf/Tpgm7EenESgvsGZJA==", "d1836c0a-e186-42b7-b9ee-a582fe03a684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4781efa7-68dc-47f2-850f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3165217-15a4-41c9-9392-2e89746f02a7", "AQAAAAIAAYagAAAAEEkM3ENuqwXVx98Yo4CbZfMRXDiDXeI4xixTJumP5NCfkl9SaOSqT6c2g5kzLrNb4A==", "3e11462d-65a7-4d6b-9686-27837237ae4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5781efa7-63dc-49f0-760f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01896bfa-1b4c-4afc-9c4e-8b896cf81626", "AQAAAAIAAYagAAAAECc/iEksj4YEhBdkmgJiRHY3rEvnNjq9OrfP3tFEryT2Lsz5T8swOpameoRRQiYa6g==", "bb145ee1-a49b-4f40-8586-01e9a2318a09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7651efa7-68dc-47f2-850f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97690d56-9f3c-4e87-8a0b-8555157bd5dd", "AQAAAAIAAYagAAAAEMCzWS1CrkDurHmr50LDc4v+F5rpN79s5RsPr32oXeyLmF2ErWp8Llg+XBXMgV8mAg==", "536530ff-7c1c-40b5-8a43-1d58c575e267" });


            migrationBuilder.UpdateData(
                table: "BusinessOwner",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "UpdatedBy", "UserId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "BusinessOwner",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "UpdatedBy", "UserId" },
                values: new object[] { null, null, null });


            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { null, null });


            migrationBuilder.UpdateData(
                table: "Rider",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Rider",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { null, null });

            migrationBuilder.DropTable(
                name: "Customer");



        }
    }
}
