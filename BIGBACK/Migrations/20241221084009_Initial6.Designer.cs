﻿// <auto-generated />
using System;
using BIGBACK.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BIGBACK.Migrations
{
    [DbContext(typeof(BIGBACKContext))]
    [Migration("20241221084009_Initial6")]
    partial class Initial6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BIGBACK.Data.BIGBACKUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BIGBACK.Domain.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BusinessAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BusinessOwnerId")
                        .HasColumnType("int");

                    b.Property<string>("BusinessRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Business");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusinessAddress = "3 Tampines Ave",
                            BusinessContact = "69876543",
                            BusinessName = "Anna's Bakery",
                            BusinessOwnerId = 1,
                            BusinessRating = "Excellent",
                            BusinessStatus = "Open"
                        },
                        new
                        {
                            Id = 2,
                            BusinessAddress = "2 Tampines Ave",
                            BusinessContact = "68765432",
                            BusinessName = "NanXiang Chicken Rice",
                            BusinessOwnerId = 2,
                            BusinessRating = "Excellent",
                            BusinessStatus = "Open"
                        });
                });

            modelBuilder.Entity("BIGBACK.Domain.BusinessOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BusinessOwnerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessOwnerGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessOwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessOwnerrContact")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BusinessOwner");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusinessOwnerEmail = "annatan@gmail.com",
                            BusinessOwnerGender = "Female",
                            BusinessOwnerName = "Anna",
                            BusinessOwnerrContact = "97564437"
                        },
                        new
                        {
                            Id = 2,
                            BusinessOwnerEmail = "JimmyLeong@gmail.com",
                            BusinessOwnerGender = "Male",
                            BusinessOwnerName = "Jimmy",
                            BusinessOwnerrContact = "97524338"
                        });
                });

            modelBuilder.Entity("BIGBACK.Domain.Complaint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ComplaintDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ComplaintDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComplaintStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("RiderID")
                        .HasColumnType("int");

                    b.Property<int>("StaffID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Complaint");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ComplaintDateTime = new DateTime(2024, 12, 21, 16, 40, 8, 272, DateTimeKind.Local).AddTicks(6014),
                            ComplaintDesc = "Late delivery",
                            ComplaintStatus = "Open",
                            OrderID = 1,
                            RiderID = 1,
                            StaffID = 1
                        },
                        new
                        {
                            Id = 2,
                            ComplaintDateTime = new DateTime(2024, 12, 21, 16, 40, 8, 272, DateTimeKind.Local).AddTicks(6017),
                            ComplaintDesc = "Damaged item",
                            ComplaintStatus = "Resolved",
                            OrderID = 2,
                            RiderID = 2,
                            StaffID = 2
                        });
                });

            modelBuilder.Entity("BIGBACK.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerMobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerAddress = "3 AngMoKio Ave",
                            CustomerEmail = "johndoe1@gmail.com",
                            CustomerGender = "Male",
                            CustomerMobileNumber = "91062378",
                            CustomerName = "John Doe"
                        },
                        new
                        {
                            Id = 2,
                            CustomerAddress = "3 Yishun Ave",
                            CustomerEmail = "maryjane2@gmail.com",
                            CustomerGender = "Female",
                            CustomerMobileNumber = "91054379",
                            CustomerName = "Mary Jane"
                        });
                });

            modelBuilder.Entity("BIGBACK.Domain.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BusinessID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DeliveryFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DeliveryStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeliveryTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Delivery");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusinessID = 1,
                            CustomerID = 1,
                            DeliveryDate = new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryFee = 5.99m,
                            DeliveryStatus = "Pending",
                            DeliveryTime = new DateTime(2024, 12, 8, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            OrderID = 1
                        },
                        new
                        {
                            Id = 2,
                            BusinessID = 1,
                            CustomerID = 2,
                            DeliveryDate = new DateTime(2024, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryFee = 7.49m,
                            DeliveryStatus = "Delivered",
                            DeliveryTime = new DateTime(2024, 12, 9, 15, 45, 0, 0, DateTimeKind.Unspecified),
                            OrderID = 2
                        });
                });

            modelBuilder.Entity("BIGBACK.Domain.DeliveryRider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<string>("DeliveryRiderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryRiderTaskType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RiderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DeliveryRider");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeliveryId = 1,
                            DeliveryRiderStatus = "Assigned",
                            DeliveryRiderTaskType = "Pickup",
                            RiderId = 1
                        },
                        new
                        {
                            Id = 2,
                            DeliveryId = 2,
                            DeliveryRiderStatus = "In Transit",
                            DeliveryRiderTaskType = "Drop-off",
                            RiderId = 2
                        });
                });

            modelBuilder.Entity("BIGBACK.Domain.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BusinessId")
                        .HasColumnType("int");

                    b.Property<string>("MenuCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusinessId = 1,
                            MenuCategory = "Cakes",
                            MenuName = "Anna's bakery book"
                        },
                        new
                        {
                            Id = 2,
                            BusinessId = 2,
                            MenuCategory = "Chicken Rice",
                            MenuName = "Chicken Rice Delights"
                        });
                });

            modelBuilder.Entity("BIGBACK.Domain.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("MenuItemDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("MenuItemPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("MenuItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MenuId = 1,
                            MenuItemDesc = "A rich, moist milk chocolate cake with a velvety texture and irresistible chocolate flavor, perfect for any sweet craving.",
                            MenuItemName = "Milk Chocolate Cake",
                            MenuItemPrice = 32f
                        },
                        new
                        {
                            Id = 2,
                            MenuId = 2,
                            MenuItemDesc = "A savory dish of tender roasted chicken served with fragrant, perfectly seasoned rice for a satisfying meal",
                            MenuItemName = "Roasted Chicken Rice",
                            MenuItemPrice = 5f
                        });
                });

            modelBuilder.Entity("BIGBACK.Domain.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            OrderDateTime = new DateTime(2024, 12, 21, 16, 40, 8, 272, DateTimeKind.Local).AddTicks(5327),
                            OrderStatus = "Pending",
                            OrderTotal = 64.50m
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            OrderDateTime = new DateTime(2024, 12, 21, 16, 40, 8, 272, DateTimeKind.Local).AddTicks(5348),
                            OrderStatus = "Pending",
                            OrderTotal = 55.70m
                        });
                });

            modelBuilder.Entity("BIGBACK.Domain.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("OrderItemPromo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderItemQty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OrderItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MenuItemId = 1,
                            OrderId = 1,
                            OrderItemQty = 1
                        },
                        new
                        {
                            Id = 2,
                            MenuItemId = 2,
                            OrderId = 2,
                            OrderItemPromo = "NEWCUSTOMER25",
                            OrderItemQty = 2
                        });
                });

            modelBuilder.Entity("BIGBACK.Domain.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal?>("PaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Payment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderId = 1,
                            PaymentAmount = 64.50m,
                            PaymentDateTime = new DateTime(2024, 12, 21, 16, 40, 8, 272, DateTimeKind.Local).AddTicks(5529),
                            PaymentMethod = "VISA Debit",
                            PaymentStatus = "Completed"
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 2,
                            PaymentAmount = 55.70m,
                            PaymentDateTime = new DateTime(2024, 12, 21, 16, 40, 8, 272, DateTimeKind.Local).AddTicks(5533),
                            PaymentMethod = "PayNow",
                            PaymentStatus = "Completed"
                        });
                });

            modelBuilder.Entity("BIGBACK.Domain.Rider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RiderContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RiderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RiderRating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Rider");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RiderContact = "+1122334455",
                            RiderName = "Charlie Brown",
                            RiderRating = 4.7999999999999998
                        },
                        new
                        {
                            Id = 2,
                            RiderContact = "+2233445566",
                            RiderName = "Daisy Lee",
                            RiderRating = 4.5
                        });
                });

            modelBuilder.Entity("BIGBACK.Domain.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StaffContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StaffContact = "+1234567890",
                            StaffEmail = "alice.johnson@example.com",
                            StaffName = "Alice Johnson"
                        },
                        new
                        {
                            Id = 2,
                            StaffContact = "+0987654321",
                            StaffEmail = "bob.smith@example.com",
                            StaffName = "Bob Smith"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BIGBACK.Data.BIGBACKUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BIGBACK.Data.BIGBACKUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BIGBACK.Data.BIGBACKUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BIGBACK.Data.BIGBACKUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}