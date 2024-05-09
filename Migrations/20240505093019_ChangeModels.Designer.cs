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
    [Migration("20240505093019_ChangeModels")]
    partial class ChangeModels
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
                            Id = new Guid("57c43782-922c-4db2-bf5f-220ac4596994"),
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
                            Id = new Guid("8bce2f33-f989-4b81-a70a-78dd2ecd6062"),
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
                            Id = new Guid("7cf6ef91-5f6a-464f-9914-96278383e66c"),
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

                    b.Property<string>("Capacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            Id = new Guid("764496ee-730e-471d-80e1-cd59b41285ff"),
                            Capacity = "1"
                        },
                        new
                        {
                            Id = new Guid("5611e014-64ca-4cbe-bdfc-5028c9f70381"),
                            Capacity = "2"
                        },
                        new
                        {
                            Id = new Guid("0a7ebca1-343f-46af-96b2-3a8f14dbd912"),
                            Capacity = "3"
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
                            Id = new Guid("df62b514-b858-4ab6-8fdb-07a056d2c612"),
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
                            Id = new Guid("1e8567ad-e847-4a52-8bf6-8a13bf65d7a8"),
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
                            Id = new Guid("e5665008-bb84-4f74-b050-9e67b7adf47a"),
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
                            Id = new Guid("78b38356-30f7-4d15-8a9d-f76f11c79989"),
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
