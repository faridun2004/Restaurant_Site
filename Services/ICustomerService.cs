using Restaurant_Site.Models;

namespace Restaurant_Site.Services
{
    public interface ICustomerService
    {
        IQueryable<Customer> GetAll();
        Customer GetById(Guid id);
        string Create(Customer customer);
        string Update(Guid id, Customer item);
        string Delete(Guid id);
    }
}
