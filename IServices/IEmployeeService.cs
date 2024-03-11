using Restaurant_Site.Models;

namespace Restaurant_Site.IServices
{
    public interface IEmployeeService : IBaseService<Employee>
    {
        Task<bool> ProcessOrderAsync(Order order);
    }
}
