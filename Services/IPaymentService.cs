using Restaurant_Site.Models;

namespace Restaurant_Site.Services
{
    public interface IPaymentService
    {
        IQueryable<Payment> GetAll();
        Payment GetById(Guid id);
        string Create(Payment item);
        string Update(Guid id, Payment item);
        string Delete(Guid id);
    }
}
