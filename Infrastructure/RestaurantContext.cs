using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Restaurant_Site.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Restaurant_Site.Infrastructure
{
    public class RestaurantContext: DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<DishDto>  DishDto { get; set; }
        public DbSet<ShopingCartItem> shopingCartItems { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.HasIndex(p => p.Username).IsUnique();
            });
            // Dish
            modelBuilder.Entity<Dish>(entity =>
            {
                entity.HasData(new Dish()
                {
                    Name = "mantu",
                    Description = "gushtin",
                    Price=20,
                    Photo="a.jpg"

                });
                entity.HasKey(p => p.Id);
            });
            //.Property(d => d.Price)
            //.HasColumnType("decimal(18,2)");
           

            // Menu
            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menus");
                entity.HasKey(m => m.Id);
            });

            // Order
            modelBuilder.Entity<Order>(entity =>
            {

                entity.ToTable("Orders");
                entity.HasKey(o => o.Id);
                entity.HasData(new Order()
                {
                    
                    Status=OrderStatus.New

                });
            });
            // Customer
            modelBuilder.Entity<Customer>()
         .Property(c => c.RefreshToken)
         .IsRequired(false);

            // Employee
            modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasData(new Employee()
            {
                FirstName = "Faridun",
                LastName = "Ikromzoda",
                Role="admin",
                Username = "Faridun",
                Password = "12"

            });
            entity.HasData(new Employee()
            {
                FirstName = "Azamjon",
                LastName = "Soliev",
                Role = "admin",
                Username = "Azam",
                Password = "123"

            });
            entity.HasData(new Employee()
            {
                FirstName = "nasim",
                LastName = "nasa",
                Role = "admin",
                Username = "Nasa",
                Password = "123"
            });

        });
                // Table
                modelBuilder.Entity<Table>(entity =>
            {
                entity.ToTable("Tables");
                entity.HasKey(t => t.Id);
            });

            // Payment
            modelBuilder.Entity<Payment>()
                 .Property(p => p.Amount)
                 .HasColumnType("decimal(18,2)");

            // Inventory
            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.ToTable("Inventories");
                entity.HasKey(i => i.Id);
            });

            // Review
            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("Reviews");
                entity.HasKey(r => r.Id);
            });
            modelBuilder.Entity<DishDto>(entity =>
            {
                entity.HasKey(p => p.Id);
            });
            modelBuilder.Entity<ShopingCartItem>(entity =>
                 entity.HasKey(sh => sh.MenuId)
            );
            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.ToTable("Deliveries");
                entity.HasKey(d => d.Id);
                // Другие настройки, если необходимо
            });
            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("Events");
                entity.HasKey(e => e.Id);
                // Другие настройки, если необходимо
            });

        }
    }
}