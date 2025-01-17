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

            //migrationBuilder.UpdateData(
            //    table: "Complaint",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    column: "ComplaintDateTime",
            //    value: new DateTime(2025, 1, 17, 11, 47, 33, 548, DateTimeKind.Local).AddTicks(1837));

            //migrationBuilder.UpdateData(
            //    table: "Complaint",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "ComplaintDateTime",
            //    value: new DateTime(2025, 1, 17, 11, 47, 33, 548, DateTimeKind.Local).AddTicks(1841));

            //migrationBuilder.UpdateData(
            //    table: "Order",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    column: "OrderDateTime",
            //    value: new DateTime(2025, 1, 17, 11, 47, 33, 548, DateTimeKind.Local).AddTicks(183));

            //migrationBuilder.UpdateData(
            //    table: "Order",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "OrderDateTime",
            //    value: new DateTime(2025, 1, 17, 11, 47, 33, 548, DateTimeKind.Local).AddTicks(214));

            //migrationBuilder.UpdateData(
            //    table: "Payment",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    column: "PaymentDateTime",
            //    value: new DateTime(2025, 1, 17, 11, 47, 33, 548, DateTimeKind.Local).AddTicks(648));

            //migrationBuilder.UpdateData(
            //    table: "Payment",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "PaymentDateTime",
            //    value: new DateTime(2025, 1, 17, 11, 47, 33, 548, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cd2bcf0c-20db-474f-8407-5a6b159518ba", "4781efa7-68dc-47f2-850f-e506d04102e4" },
                    { "dd2bcf0c-20db-474f-8407-5a6b159518bb", "5781efa7-63dc-49f0-760f-e506d04102e4" }
                });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Payment_OrderId",
            //    table: "Payment",
            //    column: "OrderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItem_MenuItemId",
            //    table: "OrderItem",
            //    column: "MenuItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItem_OrderId",
            //    table: "OrderItem",
            //    column: "OrderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Order_CustomerId",
            //    table: "Order",
            //    column: "CustomerId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MenuItem_MenuId",
            //    table: "MenuItem",
            //    column: "MenuId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Menu_BusinessId",
            //    table: "Menu",
            //    column: "BusinessId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DeliveryRider_DeliveryId",
            //    table: "DeliveryRider",
            //    column: "DeliveryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DeliveryRider_RiderId",
            //    table: "DeliveryRider",
            //    column: "RiderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Delivery_BusinessID",
            //    table: "Delivery",
            //    column: "BusinessID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Delivery_CustomerID",
            //    table: "Delivery",
            //    column: "CustomerID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Delivery_OrderID",
            //    table: "Delivery",
            //    column: "OrderID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Complaint_OrderId",
            //    table: "Complaint",
            //    column: "OrderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Complaint_RiderId",
            //    table: "Complaint",
            //    column: "RiderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Complaint_StaffId",
            //    table: "Complaint",
            //    column: "StaffId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Business_BusinessOwnerId",
            //    table: "Business",
            //    column: "BusinessOwnerId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Business_BusinessOwner_BusinessOwnerId",
            //    table: "Business",
            //    column: "BusinessOwnerId",
            //    principalTable: "BusinessOwner",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Complaint_Order_OrderId",
            //    table: "Complaint",
            //    column: "OrderId",
            //    principalTable: "Order",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Complaint_Rider_RiderId",
            //    table: "Complaint",
            //    column: "RiderId",
            //    principalTable: "Rider",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Complaint_Staff_StaffId",
            //    table: "Complaint",
            //    column: "StaffId",
            //    principalTable: "Staff",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Delivery_Business_BusinessID",
            //    table: "Delivery",
            //    column: "BusinessID",
            //    principalTable: "Business",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Delivery_Customer_CustomerID",
            //    table: "Delivery",
            //    column: "CustomerID",
            //    principalTable: "Customer",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Delivery_Order_OrderID",
            //    table: "Delivery",
            //    column: "OrderID",
            //    principalTable: "Order",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_DeliveryRider_Delivery_DeliveryId",
            //    table: "DeliveryRider",
            //    column: "DeliveryId",
            //    principalTable: "Delivery",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_DeliveryRider_Rider_RiderId",
            //    table: "DeliveryRider",
            //    column: "RiderId",
            //    principalTable: "Rider",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Menu_Business_BusinessId",
            //    table: "Menu",
            //    column: "BusinessId",
            //    principalTable: "Business",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_MenuItem_Menu_MenuId",
            //    table: "MenuItem",
            //    column: "MenuId",
            //    principalTable: "Menu",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Order_Customer_CustomerId",
            //    table: "Order",
            //    column: "CustomerId",
            //    principalTable: "Customer",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_OrderItem_MenuItem_MenuItemId",
            //    table: "OrderItem",
            //    column: "MenuItemId",
            //    principalTable: "MenuItem",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_OrderItem_Order_OrderId",
            //    table: "OrderItem",
            //    column: "OrderId",
            //    principalTable: "Order",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Payment_Order_OrderId",
            //    table: "Payment",
            //    column: "OrderId",
            //    principalTable: "Order",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Business_BusinessOwner_BusinessOwnerId",
            //    table: "Business");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Complaint_Order_OrderId",
            //    table: "Complaint");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Complaint_Rider_RiderId",
            //    table: "Complaint");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Complaint_Staff_StaffId",
            //    table: "Complaint");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Delivery_Business_BusinessID",
            //    table: "Delivery");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Delivery_Customer_CustomerID",
            //    table: "Delivery");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Delivery_Order_OrderID",
            //    table: "Delivery");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_DeliveryRider_Delivery_DeliveryId",
            //    table: "DeliveryRider");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_DeliveryRider_Rider_RiderId",
            //    table: "DeliveryRider");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Menu_Business_BusinessId",
            //    table: "Menu");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_MenuItem_Menu_MenuId",
            //    table: "MenuItem");

            ////migrationBuilder.DropForeignKey(
            ////    name: "FK_Order_Customer_CustomerId",
            ////    table: "Order");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_OrderItem_MenuItem_MenuItemId",
            //    table: "OrderItem");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_OrderItem_Order_OrderId",
            //    table: "OrderItem");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Payment_Order_OrderId",
            //    table: "Payment");

            //migrationBuilder.DropIndex(
            //    name: "IX_Payment_OrderId",
            //    table: "Payment");

            //migrationBuilder.DropIndex(
            //    name: "IX_OrderItem_MenuItemId",
            //    table: "OrderItem");

            //migrationBuilder.DropIndex(
            //    name: "IX_OrderItem_OrderId",
            //    table: "OrderItem");

            //migrationBuilder.DropIndex(
            //    name: "IX_Order_CustomerId",
            //    table: "Order");

            //migrationBuilder.DropIndex(
            //    name: "IX_MenuItem_MenuId",
            //    table: "MenuItem");

            //migrationBuilder.DropIndex(
            //    name: "IX_Menu_BusinessId",
            //    table: "Menu");

            //migrationBuilder.DropIndex(
            //    name: "IX_DeliveryRider_DeliveryId",
            //    table: "DeliveryRider");

            //migrationBuilder.DropIndex(
            //    name: "IX_DeliveryRider_RiderId",
            //    table: "DeliveryRider");

            //migrationBuilder.DropIndex(
            //    name: "IX_Delivery_BusinessID",
            //    table: "Delivery");

            //migrationBuilder.DropIndex(
            //    name: "IX_Delivery_CustomerID",
            //    table: "Delivery");

            //migrationBuilder.DropIndex(
            //    name: "IX_Delivery_OrderID",
            //    table: "Delivery");

            //migrationBuilder.DropIndex(
            //    name: "IX_Complaint_OrderId",
            //    table: "Complaint");

            //migrationBuilder.DropIndex(
            //    name: "IX_Complaint_RiderId",
            //    table: "Complaint");

            //migrationBuilder.DropIndex(
            //    name: "IX_Complaint_StaffId",
            //    table: "Complaint");

            //migrationBuilder.DropIndex(
            //    name: "IX_Business_BusinessOwnerId",
            //    table: "Business");

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

            //migrationBuilder.UpdateData(
            //    table: "Complaint",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    column: "ComplaintDateTime",
            //    value: new DateTime(2025, 1, 2, 12, 30, 49, 713, DateTimeKind.Local).AddTicks(3116));

            //migrationBuilder.UpdateData(
            //    table: "Complaint",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "ComplaintDateTime",
            //    value: new DateTime(2025, 1, 2, 12, 30, 49, 713, DateTimeKind.Local).AddTicks(3118));

            //migrationBuilder.UpdateData(
            //    table: "Order",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    column: "OrderDateTime",
            //    value: new DateTime(2025, 1, 2, 12, 30, 49, 713, DateTimeKind.Local).AddTicks(2305));

            //migrationBuilder.UpdateData(
            //    table: "Order",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "OrderDateTime",
            //    value: new DateTime(2025, 1, 2, 12, 30, 49, 713, DateTimeKind.Local).AddTicks(2329));

            //migrationBuilder.UpdateData(
            //    table: "Payment",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    column: "PaymentDateTime",
            //    value: new DateTime(2025, 1, 2, 12, 30, 49, 713, DateTimeKind.Local).AddTicks(2556));

            //migrationBuilder.UpdateData(
            //    table: "Payment",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "PaymentDateTime",
            //    value: new DateTime(2025, 1, 2, 12, 30, 49, 713, DateTimeKind.Local).AddTicks(2558));
        }
    }
}
