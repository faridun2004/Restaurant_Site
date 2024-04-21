﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant_Site.Infrastructure;

#nullable disable

namespace Restaurant_Site.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    partial class RestaurantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<Guid?>("OrderId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrderId1");

                    b.ToTable("Deliveries", (string)null);
                });

            modelBuilder.Entity("Restaurant_Site.Models.Dish", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("OrderId");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("afd5eeaa-76b7-4ca0-88e0-c9e254fd0879"),
                            Description = "gushtin",
                            HolderId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "mantu",
                            Photo = "a.jpg",
                            Price = 20m
                        });
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

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("TableId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TableId");

                    b.ToTable("Orders", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("68f03490-70bb-46e1-a990-e57d54516e89"),
                            Status = 0
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

                    b.ToTable("Tables", (string)null);
                });

            modelBuilder.Entity("Restaurant_Site.Models.Customer", b =>
                {
                    b.HasBaseType("Restaurant_Site.Models.Person");

                    b.Property<int>("customerStatus")
                        .HasColumnType("int");

                    b.Property<int>("customerType")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Customer");
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
                            Id = new Guid("c507ab68-9507-443c-8461-a683b7887ba6"),
                            FirstName = "Faridun",
                            LastName = "Ikromzoda",
                            Password = "12",
                            Role = "admin",
                            Username = "Faridun",
                            Responsibility = 0
                        },
                        new
                        {
                            Id = new Guid("e80bce8c-c510-4fcb-99a5-756bfd35c3f6"),
                            FirstName = "Azamjon",
                            LastName = "Soliev",
                            Password = "123",
                            Role = "admin",
                            Username = "Azam",
                            Responsibility = 0
                        },
                        new
                        {
                            Id = new Guid("9468dc1c-c27f-49d0-bed5-adeebedc17f9"),
                            FirstName = "nasim",
                            LastName = "nasa",
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
                        .HasForeignKey("OrderId1");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Restaurant_Site.Models.Dish", b =>
                {
                    b.HasOne("Restaurant_Site.Models.Menu", null)
                        .WithMany("Dishes")
                        .HasForeignKey("MenuId");

                    b.HasOne("Restaurant_Site.Models.Order", null)
                        .WithMany("Dishes")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("Restaurant_Site.Models.Order", b =>
                {
                    b.HasOne("Restaurant_Site.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Restaurant_Site.Models.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId");

                    b.Navigation("Customer");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Restaurant_Site.Models.Menu", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("Restaurant_Site.Models.Order", b =>
                {
                    b.Navigation("Dishes");
                });
#pragma warning restore 612, 618
        }
    }
}
