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
                name: "StaffID",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "RiderID",
                table: "Rider");

            migrationBuilder.DropColumn(
                name: "MenuItemId",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "DeliveryRiderId",
                table: "DeliveryRider");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "Delivery");

            migrationBuilder.DropColumn(
                name: "ComplaintID",
                table: "Complaint");

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
                name: "StaffID",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RiderID",
                table: "Rider",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "DeliveryRiderId",
                table: "DeliveryRider",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryId",
                table: "Delivery",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComplaintID",
                table: "Complaint",
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
