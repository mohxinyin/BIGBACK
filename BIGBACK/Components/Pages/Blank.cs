using Microsoft.EntityFrameworkCore.Migrations;
migrationBuilder.CreateTable(
               name: "Business",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   BusinessId = table.Column<int>(type: "int", nullable: false),
                   BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   BusinessAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   BusinessContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   BusinessRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   BusinessStatus = table.Column<int>(type: "int", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Business", x => x.Id);
               });

migrationBuilder.CreateTable(
    name: "BusinessOwner",
    columns: table => new
    {
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        BusinessOwnerId = table.Column<int>(type: "int", nullable: false),
        BusinessOwnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        BusinessOwnerrContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
        BusinessOwnerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
        BusinessOwnerGender = table.Column<string>(type: "nvarchar(max)", nullable: true)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_BusinessOwner", x => x.Id);
    });

migrationBuilder.CreateTable(
    name: "Menu",
    columns: table => new
    {
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        MenuId = table.Column<int>(type: "int", nullable: false),
        MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        BusinessId = table.Column<int>(type: "int", nullable: false),
        MenuCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_Menu", x => x.Id);
    });

migrationBuilder.CreateTable(
    name: "MenuItem",
    columns: table => new
    {
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        MenuItemId = table.Column<int>(type: "int", nullable: false),
        MenuItemPrice = table.Column<float>(type: "real", nullable: false),
        MenuItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        MenuItemDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
        MenuId = table.Column<int>(type: "int", nullable: false)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_MenuItem", x => x.Id);
    });