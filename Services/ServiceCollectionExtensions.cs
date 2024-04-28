using Restaurant_Site.IServices;
using Restaurant_Site.Repository;

namespace Restaurant_Site.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddMyServices(this IServiceCollection service)
        {
            service.AddScoped<AuthService>();
            service.AddScoped<IEmployeeService, EmployeeService>();
            service.AddScoped<ICustomerService, CustomerService>();
            service.AddScoped<IProductService, ProductService>();
            service.AddScoped<IOrderService, OrderService>();
            service.AddScoped<IPaymentService, PaymentService>();
            service.AddScoped<IReviewService, ReviewService>();
            service.AddScoped<IMenuService, MenuService>();
            service.AddScoped<IInventoryService, InventoryService>();
            service.AddScoped<ITableService, TableService>();
            service.AddScoped<IDeliveryService, DeliveryService>();
            service.AddScoped<IEventService, EventService>();
            service.AddScoped<IShoppingCartService, ShoppingCartService>();
            service.AddScoped(typeof(ISQLRepository<>), typeof(SQLRepository<>));
        }

    }
}
