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
    [Migration("20241207073441_SeedData1")]
    partial class SeedData1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                            OrderDateTime = new DateTime(2024, 12, 7, 15, 34, 41, 258, DateTimeKind.Local).AddTicks(1282),
                            OrderStatus = "Pending",
                            OrderTotal = 64.50m
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            OrderDateTime = new DateTime(2024, 12, 7, 15, 34, 41, 258, DateTimeKind.Local).AddTicks(1304),
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
                            PaymentDateTime = new DateTime(2024, 12, 7, 15, 34, 41, 258, DateTimeKind.Local).AddTicks(1475),
                            PaymentMethod = "VISA Debit",
                            PaymentStatus = "Completed"
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 2,
                            PaymentAmount = 55.70m,
                            PaymentDateTime = new DateTime(2024, 12, 7, 15, 34, 41, 258, DateTimeKind.Local).AddTicks(1478),
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
                });
#pragma warning restore 612, 618
        }
    }
}
