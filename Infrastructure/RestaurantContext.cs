using Microsoft.EntityFrameworkCore;
using Restaurant_Site.Models;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant_Site.Infrastructure
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<DishDto> DishDto { get; set; }
        public DbSet<ShopingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }

        public IEnumerable<Product> GetAllProducts()
        {
            return Menus
                .Include(m => m.Products)
                .SelectMany(m => m.Products)
                .ToList();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.HasIndex(p => p.Username).IsUnique();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasData(
                    new Product()
                    {
                        Id = Guid.NewGuid(),
                        Name = "mantu",
                        Description = "gushtin",
                        Price = 20.00,
                        Photo = "a.jpg",
                        Status = ProductStatus.Available
                    },
                    new Product()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Палов",
                        Description = "ЯК ба як",
                        Price = 100.00,
                        Photo = "palov.jpg",
                        Status = ProductStatus.Available
                    }
                );

                entity.HasKey(p => p.Id);

                entity.HasMany(p => p.Menus)
                    .WithMany(m => m.Products)
                    .UsingEntity(join => join.ToTable("ProductMenu"));
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(m => m.Id);

                entity.HasMany(m => m.Products)
                    .WithMany(p => p.Menus)
                    .UsingEntity<Dictionary<string, object>>(
                        "MenuProduct",
                        j => j.HasOne<Product>().WithMany().HasForeignKey("ProductId"),
                        j => j.HasOne<Menu>().WithMany().HasForeignKey("MenuId")
                    );
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(o => o.Id);

                entity.HasMany(o => o.products)
                    .WithOne()
                    .HasForeignKey(p => p.HolderId);

                entity.HasOne(o => o.customer)
                    .WithMany(c => c.Orders)
                    .HasForeignKey(o => o.CustomerId);

                entity.HasOne(o => o.table)
                    .WithOne()
                    .HasForeignKey<Order>(t => t.TableId);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasData(new Customer()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Azizjon",
                    LastName = "Azizov",
                    Address = "Dushanbe",
                    ContactInfo = "92-999-99-99",
                    Username = "Aziz",
                    Password = "client1",
                    Role = "client",
                    customerStatus = CustomerStatus.Regular
                });

                entity.Property(c => c.RefreshToken).IsRequired(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasData(new Employee()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Faridun",
                    LastName = "Ikromzoda",
                    Role = "admin",
                    Username = "Faridun",
                    Password = "12",
                    Address = "Asht",
                    ContactInfo = "92-977-77-77"
                });
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.ToTable("Tables");
                entity.HasKey(t => t.Id);

                entity.HasMany(t => t.Orders)
                    .WithOne(o => o.table)
                    .HasForeignKey(o => o.TableId);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(p => p.Amount).HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.ToTable("Inventories");
                entity.HasKey(i => i.Id);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("Reviews");
                entity.HasKey(r => r.Id);
            });

            modelBuilder.Entity<DishDto>(entity =>
            {
                entity.Property(d => d.Price).HasPrecision(18, 2);
            });

            modelBuilder.Entity<ShopingCartItem>(entity =>
            {
                entity.HasKey(sh => sh.MenuId);
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.HasKey(d => d.Id);
                entity.Property(d => d.DeliveryDateTime).IsRequired();
                entity.Property(d => d.DeliveryFee).HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.Order)
                    .WithMany()
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("Events");
                entity.HasKey(e => e.Id);
            });
        }
    }
}
