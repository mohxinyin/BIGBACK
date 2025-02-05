using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BIGBACK.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rider",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiderContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiderRating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffContact = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusinessOwner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BusinessOwnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessOwnerrContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessOwnerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessOwnerGender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessOwner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessOwner_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessOwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Business_BusinessOwner_BusinessOwnerId",
                        column: x => x.BusinessOwnerId,
                        principalTable: "BusinessOwner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Complaint",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    RiderId = table.Column<int>(type: "int", nullable: false),
                    ComplaintDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplaintStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplaintDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complaint_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Complaint_Rider_RiderId",
                        column: x => x.RiderId,
                        principalTable: "Rider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Complaint_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    BusinessID = table.Column<int>(type: "int", nullable: false),
                    DeliveryFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeliveryStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.Id);
                    //table.ForeignKey(
                    //    name: "FK_Delivery_Business_BusinessID",
                    //    column: x => x.BusinessID,
                    //    principalTable: "Business",
                    //    principalColumn: "Id",
                    //    onDelete: ReferentialAction.Cascade);
                    //table.ForeignKey(
                    //    name: "FK_Delivery_Customer_CustomerID",
                    //    column: x => x.CustomerID,
                    //    principalTable: "Customer",
                    //    principalColumn: "Id",
                    //    onDelete: ReferentialAction.Cascade);
                    //table.ForeignKey(
                    //    name: "FK_Delivery_Order_OrderID",
                    //    column: x => x.OrderID,
                    //    principalTable: "Order",
                    //    principalColumn: "Id",
                    //    onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessId = table.Column<int>(type: "int", nullable: false),
                    MenuCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryRider",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryRiderTaskType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryRiderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryId = table.Column<int>(type: "int", nullable: false),
                    RiderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryRider", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryRider_Delivery_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Delivery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeliveryRider_Rider_RiderId",
                        column: x => x.RiderId,
                        principalTable: "Rider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItemPrice = table.Column<float>(type: "real", nullable: false),
                    MenuItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuItemDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItem_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderItemQty = table.Column<int>(type: "int", nullable: true),
                    OrderItemPromo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    MenuItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_MenuItem_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" },
                    { "cd2bcf0c-20db-474f-8407-5a6b159518ba", null, "BusinessOwner", "BUSINESSOWNER" },
                    { "dd2bcf0c-20db-474f-8407-5a6b159518bb", null, "Rider", "RIDER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "cbecc624-b7a6-4943-9c89-d25a3eea3d62", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBNgZsvmYGVhvKQDYIzB3sEdB9MzZKKXsdhgnl5k2Na9OuFSKGe9b6tXLjoclb03Ow==", null, false, "7e7cbb23-d35f-4c41-bae7-9a366ad17261", false, "admin@localhost.com" },
                    { "4781efa7-68dc-47f2-850f-e506d04102e4", 0, "8a0d749d-18e6-4865-95c5-3433fe71e414", "business_annaBakery@localhost.com", true, "Anna", "Businessowner", false, null, "BUSINESS_ANNABAKERY@LOCALHOST.COM", "BUSINESS_ANNABAKERY@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMo9lnzsWU9l0ovtOKCDtgn+/H0rkM4GsAFmcwSGa//6hakx4BeLWoPFQdE1O3IY3A==", null, false, "65c243db-cfbf-4d87-88df-886eccf5ff25", false, "business_annaBakery@localhost.com" },
                    { "5781efa7-63dc-49f0-760f-e506d04102e4", 0, "e3c3152b-e43e-4ab0-a81e-96949b8b5d83", "rider_charlie@localhost.com", true, "Charlie", "Brown", false, null, "RIDER_CHARLIE@LOCALHOST.COM", "RIDER_CHARLIE@LOCALHOST.COM", "AQAAAAIAAYagAAAAEG2iXdzQKPaUZuQ8vZ4NhvFNNTyLuYdTuFeYqjKtMiDl3ibnqztxD7GcLZsKi6FwCg==", null, false, "dd314d41-c5fd-427d-80ff-15f4e117776c", false, "rider_charlie@localhost.com" },
                    { "7651efa7-68dc-47f2-850f-e506d04102e4", 0, "d24821eb-80c5-49d6-b1ff-c0b60b1b53fc", "business_jimmyChicken@localhost.com", true, "Jimmy", "Businessowner", false, null, "BUSINESS_JIMMYCHICKEN@LOCALHOST.COM", "BUSINESS_JIMMYCHICKEN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHMVKYPycsUqi6JYxnwsLTdRIMwdFngi+t5IQ6sOGMOCWnGspflVjbmvr4AINkwHog==", null, false, "cd03ba6f-9656-408a-972d-649b9e5c94d7", false, "business_jimmyChicken@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CustomerAddress", "CustomerEmail", "CustomerGender", "CustomerMobileNumber", "CustomerName" },
                values: new object[,]
                {
                    { 1, "3 AngMoKio Ave", "johndoe1@gmail.com", "Male", "91062378", "John Doe" },
                    { 2, "3 Yishun Ave", "maryjane2@gmail.com", "Female", "91054379", "Mary Jane" }
                });

            migrationBuilder.InsertData(
                table: "Rider",
                columns: new[] { "Id", "RiderContact", "RiderName", "RiderRating" },
                values: new object[,]
                {
                    { 1, "+1122334455", "Charlie Brown", 4.7999999999999998 },
                    { 2, "+2233445566", "Daisy Lee", 4.5 }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "StaffContact", "StaffEmail", "StaffName" },
                values: new object[,]
                {
                    { 1, "+1234567890", "alice.johnson@example.com", "Alice Johnson" },
                    { 2, "+0987654321", "bob.smith@example.com", "Bob Smith" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "cd2bcf0c-20db-474f-8407-5a6b159518ba", "4781efa7-68dc-47f2-850f-e506d04102e4" },
                    { "dd2bcf0c-20db-474f-8407-5a6b159518bb", "5781efa7-63dc-49f0-760f-e506d04102e4" },
                    { "cd2bcf0c-20db-474f-8407-5a6b159518ba", "7651efa7-68dc-47f2-850f-e506d04102e4" }
                });

            migrationBuilder.InsertData(
                table: "BusinessOwner",
                columns: new[] { "Id", "BusinessOwnerEmail", "BusinessOwnerGender", "BusinessOwnerName", "BusinessOwnerrContact", "UserId" },
                values: new object[,]
                {
                    { 1, "business_annaBakery@localhost.com", "Female", "Anna", "97564437", "4781efa7-68dc-47f2-850f-e506d04102e4" },
                    { 2, "business_jimmyChicken@localhost.com", "Male", "Jimmy", "97524338", "7651efa7-68dc-47f2-850f-e506d04102e4" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CustomerId", "OrderDateTime", "OrderStatus", "OrderTotal" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 2, 3, 1, 27, 2, 265, DateTimeKind.Local).AddTicks(5487), "Pending", 64.50m },
                    { 2, 2, new DateTime(2025, 2, 3, 1, 27, 2, 265, DateTimeKind.Local).AddTicks(5531), "Pending", 55.70m }
                });

            migrationBuilder.InsertData(
                table: "Business",
                columns: new[] { "Id", "BusinessAddress", "BusinessContact", "BusinessName", "BusinessOwnerId", "BusinessRating", "BusinessStatus" },
                values: new object[,]
                {
                    { 1, "3 Tampines Ave", "69876543", "Anna's Bakery", 1, "Excellent", "Open" },
                    { 2, "2 Tampines Ave", "68765432", "NanXiang Chicken Rice", 2, "Excellent", "Open" }
                });

            migrationBuilder.InsertData(
                table: "Complaint",
                columns: new[] { "Id", "ComplaintDateTime", "ComplaintDesc", "ComplaintStatus", "OrderId", "RiderId", "StaffId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 3, 1, 27, 2, 265, DateTimeKind.Local).AddTicks(7264), "Late delivery", "Open", 1, 1, 1 },
                    { 2, new DateTime(2025, 2, 3, 1, 27, 2, 265, DateTimeKind.Local).AddTicks(7270), "Damaged item", "Resolved", 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "OrderId", "PaymentAmount", "PaymentDateTime", "PaymentMethod", "PaymentStatus" },
                values: new object[,]
                {
                    { 1, 1, 64.50m, new DateTime(2025, 2, 3, 1, 27, 2, 265, DateTimeKind.Local).AddTicks(6116), "VISA Debit", "Completed" },
                    { 2, 2, 55.70m, new DateTime(2025, 2, 3, 1, 27, 2, 265, DateTimeKind.Local).AddTicks(6123), "PayNow", "Completed" }
                });

            migrationBuilder.InsertData(
                table: "Delivery",
                columns: new[] { "Id", "BusinessID", "CustomerID", "DeliveryDate", "DeliveryFee", "DeliveryStatus", "DeliveryTime", "OrderID" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.99m, "Pending", new DateTime(2024, 12, 8, 10, 30, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 1, 2, new DateTime(2024, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.49m, "Delivered", new DateTime(2024, 12, 9, 15, 45, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "BusinessId", "MenuCategory", "MenuName" },
                values: new object[,]
                {
                    { 1, 1, "Cakes", "Anna's bakery book" },
                    { 2, 2, "Chicken Rice", "Chicken Rice Delights" }
                });

            migrationBuilder.InsertData(
                table: "DeliveryRider",
                columns: new[] { "Id", "DeliveryId", "DeliveryRiderStatus", "DeliveryRiderTaskType", "RiderId" },
                values: new object[,]
                {
                    { 1, 1, "Assigned", "Pickup", 1 },
                    { 2, 2, "In Transit", "Drop-off", 2 }
                });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "MenuId", "MenuItemDesc", "MenuItemName", "MenuItemPrice" },
                values: new object[,]
                {
                    { 1, 1, "A rich, moist milk chocolate cake with a velvety texture and irresistible chocolate flavor, perfect for any sweet craving.", "Milk Chocolate Cake", 32f },
                    { 2, 2, "A savory dish of tender roasted chicken served with fragrant, perfectly seasoned rice for a satisfying meal", "Roasted Chicken Rice", 5f }
                });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "Id", "MenuItemId", "OrderId", "OrderItemPromo", "OrderItemQty" },
                values: new object[,]
                {
                    { 1, 1, 1, null, 1 },
                    { 2, 2, 2, "NEWCUSTOMER25", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessOwnerId",
                table: "Business",
                column: "BusinessOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessOwner_UserId",
                table: "BusinessOwner",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_OrderId",
                table: "Complaint",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_RiderId",
                table: "Complaint",
                column: "RiderId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_StaffId",
                table: "Complaint",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_BusinessID",
                table: "Delivery",
                column: "BusinessID");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_CustomerID",
                table: "Delivery",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_OrderID",
                table: "Delivery",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryRider_DeliveryId",
                table: "DeliveryRider",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryRider_RiderId",
                table: "DeliveryRider",
                column: "RiderId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_BusinessId",
                table: "Menu",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_MenuId",
                table: "MenuItem",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_MenuItemId",
                table: "OrderItem",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderId",
                table: "Payment",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Complaint");

            migrationBuilder.DropTable(
                name: "DeliveryRider");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "Rider");

            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.DropTable(
                name: "BusinessOwner");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
