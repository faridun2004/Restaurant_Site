using Microsoft.EntityFrameworkCore;
using Restaurant_Site.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Restaurant_Site.Infrastructure
{
    public class RestaurantContext: DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        { }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Dish
            modelBuilder.Entity<Dish>()
        .Property(d => d.Price)
        .HasColumnType("decimal(18,2)");

            

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
            });

            // Customer
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customers");
                entity.HasKey(c => c.Id);
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
        }
    }
}

