using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class CreatedByUpdatedBy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Staff",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Staff",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Rider",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Rider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Rider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Rider",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "BusinessOwner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "BusinessOwner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "BusinessOwner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "BusinessOwner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb77b42d-e531-4a39-82ae-e38af1c08209", "AQAAAAIAAYagAAAAEB8NQ5tyzhUndw/wYO+dPKeHjqSCUzAjSJ365uxy3D2XM4KU5lPXkRP7cbjCkV4NGA==", "cfb9319c-ee1a-4f76-a77d-777afd326357" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4781efa7-68dc-47f2-850f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2798c65e-f593-4bb2-abfe-187719bebfee", "AQAAAAIAAYagAAAAELM6N/iE/4pD2Rm5qSLeLeYCdI8rRuPrNVFmyIuW7GeZa79opNHC8TEp5mf3ytrSgA==", "6ca67cea-bb65-4464-aa39-8ada5e82eca2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5781efa7-63dc-49f0-760f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09a8eaed-a573-41bf-bd5d-ee978582cbd9", "AQAAAAIAAYagAAAAEA7gSRpnPz0cJwbv/e9o8dQHayXe5LAvXkgb4JSD5OTPcRjAnzvCGtTBwC8P6Q7FQg==", "4f096c30-8869-4761-b51f-5701f2ce0894" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7651efa7-68dc-47f2-850f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fef354ee-e7b1-4c6f-ba55-1fa21b0c46b2", "AQAAAAIAAYagAAAAEOrBdVjjTzAt5bxrfpKI9n/rlnI0mG6g1JtD/ABwOGnWzJY9yCk9M3qFN0IBVc7GUQ==", "a1f2e0bf-5afa-4881-b4d0-30c0699d2a25" });

            migrationBuilder.UpdateData(
                table: "BusinessOwner",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "BusinessOwner",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 1,
                column: "ComplaintDateTime",
                value: new DateTime(2025, 2, 4, 20, 9, 25, 366, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 2,
                column: "ComplaintDateTime",
                value: new DateTime(2025, 2, 4, 20, 9, 25, 366, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2025, 2, 4, 20, 9, 25, 366, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2025, 2, 4, 20, 9, 25, 366, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDateTime",
                value: new DateTime(2025, 2, 4, 20, 9, 25, 366, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDateTime",
                value: new DateTime(2025, 2, 4, 20, 9, 25, 366, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Rider",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Rider",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Rider");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Rider");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Rider");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Rider");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "BusinessOwner");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "BusinessOwner");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "BusinessOwner");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "BusinessOwner");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbecc624-b7a6-4943-9c89-d25a3eea3d62", "AQAAAAIAAYagAAAAEBNgZsvmYGVhvKQDYIzB3sEdB9MzZKKXsdhgnl5k2Na9OuFSKGe9b6tXLjoclb03Ow==", "7e7cbb23-d35f-4c41-bae7-9a366ad17261" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4781efa7-68dc-47f2-850f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a0d749d-18e6-4865-95c5-3433fe71e414", "AQAAAAIAAYagAAAAEMo9lnzsWU9l0ovtOKCDtgn+/H0rkM4GsAFmcwSGa//6hakx4BeLWoPFQdE1O3IY3A==", "65c243db-cfbf-4d87-88df-886eccf5ff25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5781efa7-63dc-49f0-760f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3c3152b-e43e-4ab0-a81e-96949b8b5d83", "AQAAAAIAAYagAAAAEG2iXdzQKPaUZuQ8vZ4NhvFNNTyLuYdTuFeYqjKtMiDl3ibnqztxD7GcLZsKi6FwCg==", "dd314d41-c5fd-427d-80ff-15f4e117776c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7651efa7-68dc-47f2-850f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d24821eb-80c5-49d6-b1ff-c0b60b1b53fc", "AQAAAAIAAYagAAAAEHMVKYPycsUqi6JYxnwsLTdRIMwdFngi+t5IQ6sOGMOCWnGspflVjbmvr4AINkwHog==", "cd03ba6f-9656-408a-972d-649b9e5c94d7" });

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 1,
                column: "ComplaintDateTime",
                value: new DateTime(2025, 2, 3, 1, 27, 2, 265, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Complaint",
                keyColumn: "Id",
                keyValue: 2,
                column: "ComplaintDateTime",
                value: new DateTime(2025, 2, 3, 1, 27, 2, 265, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2025, 2, 3, 1, 27, 2, 265, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2025, 2, 3, 1, 27, 2, 265, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDateTime",
                value: new DateTime(2025, 2, 3, 1, 27, 2, 265, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDateTime",
                value: new DateTime(2025, 2, 3, 1, 27, 2, 265, DateTimeKind.Local).AddTicks(6123));
        }
    }
}