using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BusinessStatus",
                table: "Business",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BusinessOwnerId",
                table: "Business",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Business",
                columns: new[] { "Id", "BusinessAddress", "BusinessContact", "BusinessName", "BusinessOwnerId", "BusinessRating", "BusinessStatus" },
                values: new object[,]
                {
                    { 1, "3 Tampines Ave", "69876543", "Anna's Bakery", 1, "Excellent", "Open" },
                    { 2, "2 Tampines Ave", "68765432", "NanXiang Chicken Rice", 2, "Excellent", "Open" }
                });

            migrationBuilder.InsertData(
                table: "BusinessOwner",
                columns: new[] { "Id", "BusinessOwnerEmail", "BusinessOwnerGender", "BusinessOwnerName", "BusinessOwnerrContact" },
                values: new object[,]
                {
                    { 1, "annatan@gmail.com", "Female", "Anna", "97564437" },
                    { 2, "JimmyLeong@gmail.com", "Male", "Jimmy", "97524338" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "BusinessId", "MenuCategory", "MenuName" },
                values: new object[,]
                {
                    { 1, 1, "Cakes", "Anna's bakery book" },
                    { 2, 2, "Chicken Rice", "Chicken RIce Delights" }
                });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "MenuId", "MenuItemDesc", "MenuItemName", "MenuItemPrice" },
                values: new object[,]
                {
                    { 1, 1, "A rich, moist milk chocolate cake with a velvety texture and irresistible chocolate flavor, perfect for any sweet craving.", "Milk Chocolate Cake", 32f },
                    { 2, 2, "A savory dish of tender roasted chicken served with fragrant, perfectly seasoned rice for a satisfying meal", "69876543", 5f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Business",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Business",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BusinessOwner",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BusinessOwner",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "BusinessOwnerId",
                table: "Business");

            migrationBuilder.AlterColumn<int>(
                name: "BusinessStatus",
                table: "Business",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
