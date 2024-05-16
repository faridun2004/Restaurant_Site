using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.Repository;

namespace Restaurant_Site.Services
{
    public class PaymentService : IPaymentService
    {
        ISQLRepository<Payment> _repository;

        public PaymentService(ISQLRepository<Payment> repository)
        {
            _repository = repository;
        }

        public IQueryable<Payment> GetAll()
        {
            return _repository.GetAll();
        }
        public IQueryable<Payment> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<Payment> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public Payment TryCreate(Payment item, out string message)
        {
            if (string.IsNullOrEmpty(item.Date.ToString()))
            {
                message = "The name or description is be empty!";
                return default;
            }
            return _repository.TryCreate(item, out message);
        }

        public bool TryUpdate(Guid id, Payment item, out string message)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is null)
            {
                message = "Item not found";
                return false;
            }
            else
            {
                _item.Amount = item.Amount;
                _item.Date = item.Date;

                return _repository.TryUpdate(_item, out message);
            }

        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }
    }
}
