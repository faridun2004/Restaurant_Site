using Microsoft.EntityFrameworkCore;
using Restaurant_Site.Models;
using Restaurant_Site.Models.finances;
using Restaurant_Site.server.Infrastructure;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.Infrastructure
{
    public class RestaurantContext : DbContext, IRestaurantContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) { }       
        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; } 
        public DbSet<OrderDetail> OrderDetails { get; set; }
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
        public DbSet<CashRegister> CashRegisters { get; set; }
        public DbSet<Expense> Expense {  get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<FinancialTransaction> FinancialTransactions { get; set; }
        public DbSet<Salary> Salarys { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public IQueryable<T> GetEntities<T>() where T : class
        {
            return Set<T>();
        }
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
            modelBuilder.Entity<Product>(async entity =>
            {
                entity.HasData(
                    new Product()
                    {
                        Id = Guid.NewGuid(),
                        Name = "mantu",
                        Description = "gushtin",
                        Price = 20,
                        Photo = "b.jpg",
                        Status = ProductStatus.Available
                    },
                    new Product()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Палов",
                        Description = "ЯК ба як",
                        Price = 100,
                        Photo = "a.jpg",
                        Status = ProductStatus.Available
                    }
                );
                entity.HasKey(p => p.Id);
                entity.HasMany(p => p.Menus)
                      .WithMany(m => m.Products)
                      .UsingEntity(join => join.ToTable("ProductMenu"));
                entity.Property(p => p.Price)
                      .HasColumnType("decimal(18, 2)");
            });
            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(m => m.Id);
                entity.HasMany(m => m.Products)
                      .WithMany(p => p.Menus)
                      .UsingEntity<Dictionary<string, object>>(
                        "MenuProduct",
                        join => join.HasOne<Product>().WithMany().HasForeignKey("ProductId"),
                        join => join.HasOne<Menu>().WithMany().HasForeignKey("MenuId")
                    );
            });
            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasOne(od => od.Product)
                      .WithMany()
                      .HasForeignKey(od => od.ProductId);
                entity.HasOne(od => od.Customer)
                      .WithMany()
                      .HasForeignKey(od => od.CustomerId);
                entity.HasOne(od => od.Table)
                      .WithMany()
                      .HasForeignKey(od => od.TableId);
                entity.HasOne(od => od.Employee)
                      .WithMany()
                      .HasForeignKey(od => od.EmployeeId);
                entity.HasOne(od => od.Order)
                      .WithMany(o => o.OrderDetails)
                      .HasForeignKey(od => od.OrderId);
                entity.Property(od => od.ProductId)
                      .IsRequired();
                entity.Property(od => od.CustomerId)
                      .IsRequired();
                entity.Property(od => od.TableId)
                      .IsRequired();
                entity.Property(od => od.EmployeeId)
                      .IsRequired();
                entity.Property(od => od.OrderId)
                       .IsRequired();
                entity.Property(od => od.CretionalDate)
                      .ValueGeneratedOnAdd()
                      .IsRequired();
                entity.Property(od => od.EditDate)
                      .ValueGeneratedOnAddOrUpdate()
                      .IsRequired();

            });
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e=>e.Id);
                entity.HasMany(o => o.OrderDetails)
                      .WithOne(d => d.Order)
                      .HasForeignKey(d => d.OrderId)
                      .IsRequired()
                      .OnDelete(DeleteBehavior.Cascade);
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
                entity.HasMany(c => c.Orders)
                      .WithOne(o => o.Customer)
                      .HasForeignKey(o => o.CustomerId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.Property(c => c.customerStatus)
                      .IsRequired();
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
                entity.HasMany(e => e.Orders)
                      .WithOne(o => o.Employee)
                      .HasForeignKey(o => o.EmployeeId)
                      .OnDelete(DeleteBehavior.Restrict); 
                entity.Property(e => e.Responsibility)
                      .IsRequired();
                entity.Property(e => e.IsAvailable)
                      .IsRequired();
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.ToTable("Tables");
                entity.HasKey(t => t.Id);
                entity.HasData(new Table()
                {
                    Capacity = "1"
                });
                entity.HasMany(t => t.Orders)
                      .WithOne(o => o.Table)
                      .HasForeignKey(o => o.TableId)
                      .OnDelete(DeleteBehavior.Restrict); 
                entity.Property(t => t.Capacity)
                      .HasMaxLength(255);
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
            modelBuilder.Entity<CashRegister>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.CashAmount)
                      .HasColumnType("decimal(18,2)") 
                      .IsRequired();
                entity.Property(c => c.RegisterDateTime)
                      .IsRequired();
            });
            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Description)
                      .HasMaxLength(255); 
                entity.Property(e => e.Amount)
                      .HasColumnType("decimal(18,2)") 
                      .IsRequired();
                entity.Property(e => e.ExpenseDateTime)
                      .IsRequired();
                entity.HasOne(e => e.Category)
                      .WithMany()
                      .HasForeignKey(e => e.CategoryId)
                      .IsRequired(false);
            });
            modelBuilder.Entity<ExpenseCategory>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name)
                      .HasMaxLength(255);
                entity.HasMany(ec => ec.Expenses)
                      .WithOne(e => e.Category)
                      .HasForeignKey(e => e.CategoryId)
                      .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<FinancialTransaction>(entity =>
            {
                entity.HasKey(F => F.Id);
                entity.Property(t => t.Amount)
                      .HasColumnType("decimal(18,2)") 
                      .IsRequired();
                entity.Property(t => t.TransactionDateTime)
                      .IsRequired();
                entity.Property(t => t.Description)
                      .HasMaxLength(255);
            });
            modelBuilder.Entity<Salary>(entity =>
            {
                entity.HasKey(s => s.Id);

                entity.Property(s => s.Amount)
                      .HasColumnType("decimal(18,2)") 
                      .IsRequired();
                entity.Property(s => s.SalaryDateTime)
                      .IsRequired();
                entity.HasOne(s => s.Employee)
                      .WithMany(e => e.Salaries)
                      .HasForeignKey(s => s.EmployeeId)
                      .IsRequired(false);
            });
            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(s => s.Id);

                entity.Property(s => s.SaleDateTime)
               .IsRequired();
                entity.Property(s => s.TotalAmount)
                       .HasColumnType("decimal(18,2)") 
                       .IsRequired();
                entity.HasMany(s => s.ProductsSold)
                       .WithMany()
                       .UsingEntity(j => j.ToTable("SaleProducts")); 
                entity.HasOne(s => s.Employee)
                       .WithMany(e => e.Sales)
                       .HasForeignKey(s => s.EmployeeId)
                       .IsRequired(false); 
                entity.HasOne(s => s.Order)
                       .WithOne(o => o.Sale)
                       .HasForeignKey<Sale>(s => s.Id)
                       .IsRequired(false);
            });
        }
    }
}

