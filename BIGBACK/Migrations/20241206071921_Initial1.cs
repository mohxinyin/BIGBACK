using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class Initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         

            migrationBuilder.DropColumn(
                name: "MenuItemId",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Menu");

          

          

            migrationBuilder.DropColumn(
                name: "BusinessOwnerId",
                table: "BusinessOwner");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "Business");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<int>(
                name: "MenuItemId",
                table: "MenuItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                table: "Menu",
                type: "int",
                nullable: false,
                defaultValue: 0);

         

            

            migrationBuilder.AddColumn<int>(
                name: "BusinessOwnerId",
                table: "BusinessOwner",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BusinessId",
                table: "Business",
                type: "int",
                nullable: false,
                defaultValue: 0);

        }
    }
}
