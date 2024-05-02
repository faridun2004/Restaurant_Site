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
                            Id = new Guid("ad3d4f8b-4a5a-4b79-83c7-8abb1c747c08"),
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
                            Id = new Guid("686e8d14-4e8a-40bf-8f81-f083656f031c"),
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
                            Id = new Guid("ba0caf2f-3fd0-4bb1-a977-a0e4d834484d"),
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
                            Id = new Guid("e4ac66ea-4d89-46dd-ac88-32eb9c962957"),
                            Capacity = 1
                        },
                        new
                        {
                            Id = new Guid("637e4064-f0af-43f2-867a-e88039fcea29"),
                            Capacity = 2
                        });
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
                            Id = new Guid("bd0cd23f-059c-4c53-85e6-b5b6e11c9bd0"),
                            FirstName = "Faridun",
                            LastName = "Ikromzoda",
                            Password = "12",
                            Role = "admin",
                            Username = "Faridun",
                            Responsibility = 0
                        },
                        new
                        {
                            Id = new Guid("79ce2018-b792-4ae1-bf70-4697966c048b"),
                            FirstName = "Azamjon",
                            LastName = "Soliev",
                            Password = "123",
                            Role = "admin",
                            Username = "Azam",
                            Responsibility = 0
                        },
                        new
                        {
                            Id = new Guid("42a2422e-06bc-4520-b455-f2c05fd67ad9"),
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
