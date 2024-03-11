using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Restaurant_Site.Infrastructure;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.Repository;
using Restaurant_Site.Services;
using System.Text.Json.Serialization;

namespace Restaurant_Site
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<RestaurantContext>(con => con.UseSqlServer(builder.Configuration["ConnectionString"])
                      .LogTo(Console.Write, LogLevel.Error)
          .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            builder.Services.AddLogging(l =>
            {
               // l.AddConsole();//TODO
            });

            builder.Services.AddControllers()
           .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IDishService, DishService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IPaymentService, PaymentService>();
            builder.Services.AddScoped<IReviewService, ReviewService>();
            builder.Services.AddScoped<IMenuService, MenuService>();
            builder.Services.AddScoped<IInventoryService, InventoryService>();
            builder.Services.AddScoped<ITableService, TableService>();
            builder.Services.AddScoped(typeof(ISQLRepository<>), typeof(SQLRepository<>));
            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<RestaurantContext>();
                context.Database.Migrate();
            }
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
