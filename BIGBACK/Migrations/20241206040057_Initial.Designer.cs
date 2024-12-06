﻿// <auto-generated />
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
    [Migration("20241206040057_Initial")]
    partial class Initial
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

                    b.Property<int>("BusinessId")
                        .HasColumnType("int");

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

                    b.Property<int>("BusinessOwnerId")
                        .HasColumnType("int");

                    b.Property<string>("BusinessOwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessOwnerrContact")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BusinessOwner");
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

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

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

                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<string>("MenuItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("MenuItemPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("MenuItem");
                });
#pragma warning restore 612, 618
        }
    }
}
