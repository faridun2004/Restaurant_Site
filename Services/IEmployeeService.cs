using Restaurant_Site.Models;

namespace Restaurant_Site.Services
{
    public interface IEmployeeService
    {
        IQueryable<Employee> GetAll();
        Employee GetById(Guid id);
        string Create(Employee employee);
        string Update(Guid id, Employee item);
        string Delete(Guid id);
    }
}
