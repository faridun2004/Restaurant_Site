using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Restaurant_Site.Auth;
using Restaurant_Site.Infrastructure;
using Restaurant_Site.IServices;
using Restaurant_Site.Middlewares;
using Restaurant_Site.Models;
using Restaurant_Site.Repository;
using Restaurant_Site.Services;
using Restaurant_Site.Validations;
using System.Text.Json.Serialization;
using FluentValidation;
namespace Restaurant_Site
{
    public class Program
    {
        public const string AppKey = "TestKey";
        public static void Main(string[] args)
        {  
            var builder = WebApplication.CreateBuilder(args);

            //Adding custom Auth
            builder.Services.AddMyAuth();
            // Add services to the container.
            builder.Services.AddDbContext<RestaurantContext>(con => con.UseSqlServer(builder.Configuration["ConnectionString"])
                      .LogTo(Console.Write, LogLevel.Error)
          .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            builder.Services.AddLogging();

            
            builder.Services.AddControllers()
           .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
            builder.Services.AddValidatorsFromAssemblyContaining<DishDtoValidation>();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Restaurant application APIs", Version = "v1" });

                // Add the JWT Bearer authentication scheme
                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Description = "JWT Authorization header using the Bearer scheme.",
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
                };
                c.AddSecurityDefinition("Bearer", securityScheme);

                // Use the JWT Bearer authentication scheme globally
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                { securityScheme, new List<string>() }
            });
            });

            //Adding custom services
            builder.Services.AddMyServices();
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });

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
            app.UseCors();
            app.UseMiddleware<GlobalExceptionMiddleware>();
            app.UseMiddleware<ApplicationKeyMiddleware>();
            app.UseMiddleware<EndpointListenerMiddleware>();
           
            //app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}