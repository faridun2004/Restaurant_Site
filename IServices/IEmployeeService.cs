using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.IServices
{
    public interface IEmployeeService : IBaseService<Employee>
    {
        Task<bool> ProcessOrderAsync(Order order);
    }
}
