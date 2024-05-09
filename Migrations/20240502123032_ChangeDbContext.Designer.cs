﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant_Site.Infrastructure;

#nullable disable

namespace Restaurant_Site.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20240502123032_ChangeDbContext")]
    partial class ChangeDbContext
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Restaurant_Site.Models.Delivery", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeliveryDateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DeliveryFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Deliveries", (string)null);
                });

            modelBuilder.Entity("Restaurant_Site.Models.DishDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HolderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IssuerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("dishStatus")
                        .HasColumnType("int");

                    b.Property<int>("dishType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DishDto");
                });

            modelBuilder.Entity("Restaurant_Site.Models.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Events", (string)null);
                });

            modelBuilder.Entity("Restaurant_Site.Models.Inventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Inventories", (string)null);
                });

            modelBuilder.Entity("Restaurant_Site.Models.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Menus", (string)null);
                });

            modelBuilder.Entity("Restaurant_Site.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CretionalDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("customerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("status")
                        .HasColumnType("int");

                    b.Property<Guid?>("tableId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("customerId");

                    b.HasIndex("tableId");

                    b.ToTable("Orders", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("89928762-dacb-403a-b0f8-8fef321365ea"),
                            CretionalDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            status = 0
                        });
                });

            modelBuilder.Entity("Restaurant_Site.Models.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Restaurant_Site.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Restaurant_Site.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DishType")
                        .HasColumnType("int");

                    b.Property<Guid>("HolderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MenuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("02b45abc-2d9c-46c3-8c2c-206b2b6cdc36"),
                            Description = "gushtin",
                            DishType = 0,
                            HolderId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "mantu",
                            Photo = "a.jpg",
                            Price = 20m,
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("6d3fd180-c18a-4d6a-a8cd-48f4441b1fd0"),
                            Description = "ЯК ба як",
                            DishType = 0,
                            HolderId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Палов",
                            Photo = "palov.jpg",
                            Price = 100m,
                            Status = 0
                        });
                });

            modelBuilder.Entity("Restaurant_Site.Models.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Reviews", (string)null);
                });

            modelBuilder.Entity("Restaurant_Site.Models.ShopingCartItem", b =>
                {
                    b.Property<Guid>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("MenuId");

                    b.ToTable("shopingCartItems");
                });

            modelBuilder.Entity("Restaurant_Site.Models.Table", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3422d8c9-14c6-483a-911d-04933a2afcec"),
                            Capacity = 1
                        },
                        new
                        {
                            Id = new Guid("05052943-9de5-4157-9562-78b009034f78"),
                            Capacity = 2
                        });
                });

            modelBuilder.Entity("Restaurant_Site.Models.Customer", b =>
                {
                    b.HasBaseType("Restaurant_Site.Models.Person");

                    b.Property<int>("customerStatus")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Customer");

                    b.HasData(
                        new
                        {
                            Id = new Guid("46acea22-7ddb-4222-a8c5-ac15ad1491c7"),
                            Address = "Dushanbe",
                            ContactInfo = "92-999-99-99",
                            FirstName = "Azizjon",
                            LastName = "Azizov",
                            Password = "client1",
                            Role = "client",
                            Username = "Aziz",
                            customerStatus = 0
                        });
                });

            modelBuilder.Entity("Restaurant_Site.Models.Employee", b =>
                {
                    b.HasBaseType("Restaurant_Site.Models.Person");

                    b.Property<int>("Responsibility")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Employee");

                    b.HasData(
                        new
                        {
                            Id = new Guid("41dd3790-2f9f-48ab-80a7-a5fbb2a1f7b7"),
                            Address = "Asht",
                            ContactInfo = "92-977-77-77",
                            FirstName = "Faridun",
                            LastName = "Ikromzoda",
                            Password = "12",
                            Role = "admin",
                            Username = "Faridun",
                            Responsibility = 0
                        },
                        new
                        {
                            Id = new Guid("0340e5f3-2e3a-43cd-a662-48321fee9b63"),
                            Address = "Khujand",
                            ContactInfo = "92-677-77-77",
                            FirstName = "Azamjon",
                            LastName = "Soliev",
                            Password = "123",
                            Role = "admin",
                            Username = "Azam",
                            Responsibility = 0
                        },
                        new
                        {
                            Id = new Guid("2f625f8a-b6f6-4ecc-883e-c3bfecff4ee8"),
                            Address = "Arbob",
                            ContactInfo = "92-877-77-77",
                            FirstName = "Nasimjon",
                            LastName = "Temurov",
                            Password = "123",
                            Role = "admin",
                            Username = "Nasa",
                            Responsibility = 0
                        });
                });

            modelBuilder.Entity("Restaurant_Site.Models.Delivery", b =>
                {
                    b.HasOne("Restaurant_Site.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Restaurant_Site.Models.Order", b =>
                {
                    b.HasOne("Restaurant_Site.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("customerId");

                    b.HasOne("Restaurant_Site.Models.Table", "table")
                        .WithMany()
                        .HasForeignKey("tableId");

                    b.Navigation("customer");

                    b.Navigation("table");
                });

            modelBuilder.Entity("Restaurant_Site.Models.Product", b =>
                {
                    b.HasOne("Restaurant_Site.Models.Menu", null)
                        .WithMany("Products")
                        .HasForeignKey("MenuId");

                    b.HasOne("Restaurant_Site.Models.Order", null)
                        .WithMany("products")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("Restaurant_Site.Models.Menu", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Restaurant_Site.Models.Order", b =>
                {
                    b.Navigation("products");
                });
#pragma warning restore 612, 618
        }
    }
}