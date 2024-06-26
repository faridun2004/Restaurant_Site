using Restaurant_Site.server.IServices;
using Restaurant_Site.server.IServices.IFinanceServices;
using Restaurant_Site.server.Repository;
using Restaurant_Site.server.Services.FinanceServices;
using Restaurant_Site.Services.FinanceServices;

namespace Restaurant_Site.server.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddMyServices(this IServiceCollection service)
        {
            service.AddScoped<AuthService>();
            service.AddScoped<IEmployeeService, EmployeeService>();
            service.AddScoped<ICustomerService, CustomerService>();
            service.AddScoped<IProductService, ProductService>();
            service.AddScoped<IProductCategoryService, ProductCategoryService>();
            service.AddScoped<IOrderService, OrderService>();
            service.AddScoped<IOrderDetailService, OrderDetailService>();
            service.AddScoped<IPaymentService, PaymentService>();
            service.AddScoped<IReviewService, ReviewService>();
            service.AddScoped<IInventoryService, InventoryService>();
            service.AddScoped<ITableService, TableService>();
            service.AddScoped<IDeliveryService, DeliveryService>();
            service.AddScoped<IEventService, EventService>();
            service.AddScoped<ICartService, CartService>();
            service.AddScoped<ICashRegisterService, CashRegisterService>();
            service.AddScoped<IExpenseCategoryService, ExpenseCategoryService>();
            service.AddScoped<IExpenseService, ExpenseService>();
            service.AddScoped<IFinancialTransactionService, FinancialTransactionService>();
            service.AddScoped<ISalaryService, SalaryService>();
            service.AddScoped<ISaleService, SaleService>();
            service.AddScoped<IProductRepository, ProductRepository>();
            service.AddScoped(typeof(ISQLRepository<>), typeof(SQLRepository<>));
        }

    }
}
