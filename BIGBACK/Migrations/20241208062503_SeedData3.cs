using System;
using BIGBACK.Domain;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class SeedData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            // Insert data into Rider table
            migrationBuilder.InsertData(
                table: "Rider",
                columns: new[] { "Id", "RiderName", "RiderContact", "RiderRating" },
                values: new object[,]
                {
                    { 1,"Charlie Brown", "+1122334455", 4.8 },
                    { 2,"Daisy Lee", "+2233445566", 4.5 }
                });

            // Insert data into Delivery table


            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "StaffName", "StaffEmail", "StaffContact" },
                values: new object[,]
                {
                    { 1,"Alice Johnson", "alice.johnson@example.com", "+1234567890" },
                    { 2,"Bob Smith", "bob.smith@example.com", "+0987654321" }
                });

            // Insert data into Complaint table

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Delete data from Complaint table


            // Delete data from Rider table
            migrationBuilder.DeleteData(
                table: "Rider",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rider",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

