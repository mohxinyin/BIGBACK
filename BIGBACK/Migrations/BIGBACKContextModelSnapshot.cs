﻿// <auto-generated />
using System;
using BIGBACK.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BIGBACK.Migrations
{
    [DbContext(typeof(BIGBACKContext))]
    partial class BIGBACKContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("BusinessRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BusinessStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Business");
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

                    b.Property<int?>("OrderTotal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Order");
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
                });

            modelBuilder.Entity("BIGBACK.Domain.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Payment");
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
