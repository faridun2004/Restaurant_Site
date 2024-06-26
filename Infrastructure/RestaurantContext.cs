using Microsoft.EntityFrameworkCore;
using Restaurant_Site.server.Models;
using Restaurant_Site.server.Models.finances;
using Restaurant_Site.server.Infrastructure;
using Restaurant_Site.server.Models.Enums;

namespace Restaurant_Site.Infrastructure
{
    public class RestaurantContext : DbContext, IRestaurantContext
    {
        public RestaurantContext(DbContextOptions options) : base(options)
        { }
        //public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) { }       
        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Order> Orders { get; set; } 
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<DishDto> DishDto { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> Items { get; set; }
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
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Ignore<BaseEntity>();

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.HasIndex(p => p.Username).IsUnique();
            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(p => p.Price)
                      .HasColumnType("decimal(18, 2)");
                entity.HasMany(p=>p.Sales)
                       .WithOne(s=>s.Product)
                       .HasForeignKey(s => s.ProductId)
                       .IsRequired(false);
            });


            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.ProductId).IsRequired();
                entity.Property(e => e.Quantity).IsRequired();
                entity.Property(e => e.CreationDate).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.EditDate).IsRequired(true);

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Customer)
                    .WithMany()
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Table)
                    .WithMany()
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.Property(d => d.status)
                    .HasConversion<string>()
                    .IsRequired();
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.Address)
                    .HasMaxLength(255);

                entity.HasMany(o => o.OrderDetails)
                    .WithOne(d => d.Order)
                    .HasForeignKey(d => d.OrderId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(o => o.Sale)
                        .WithMany(s => s.Order)
                        .HasForeignKey(o => o.SaleId)
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

            modelBuilder.Entity<Cart>(entity =>
            {
                modelBuilder.Entity<Cart>().HasKey(c => c.Id);

            });
            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.HasKey(c => c.CartItemId);
                entity.Property(c => c.Price)
                      .HasColumnType("decimal(18, 2)");
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
            var categoryId = Guid.NewGuid();
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
                entity.HasData(new Expense()
                {
                    Id = Guid.NewGuid(),
                    Description = "Lunch with client",
                    Amount = 45.67m,
                    ExpenseDateTime = DateTime.UtcNow,
                    CategoryId = categoryId
                });
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
                entity.HasData(new ExpenseCategory()
                {
                    Id = categoryId,
                    Name = "Meals"
                });
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
                    .UsingEntity<Dictionary<string, object>>(
                        "SaleProducts",
                        j => j.HasOne<Product>()
                              .WithMany()
                              .HasForeignKey("ProductId")
                              .OnDelete(DeleteBehavior.Cascade),
                        j => j.HasOne<Sale>()
                              .WithMany()
                              .HasForeignKey("SaleId")
                              .OnDelete(DeleteBehavior.Cascade)
                    );

                entity.HasOne(s => s.Employee)
                        .WithMany(e => e.Sales)
                        .HasForeignKey(s => s.EmployeeId)
                        .OnDelete(DeleteBehavior.Restrict);
                

            });
        }
    }
}

