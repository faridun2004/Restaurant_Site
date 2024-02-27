using Restaurant_Site.Models;
using Restaurant_Site.Repository;

//using Restaurant_Site.Repositories;
using System;
using System.Linq;

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

        public Payment GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Create(Payment item)
        {
            _repository.Create(item);
            return $"Created new payment with this ID: {item.Id}";
        }

        public string Update(Guid id, Payment item)
        {
            var existingPayment = _repository.GetById(id);
            if (existingPayment != null)
            {
                existingPayment.Amount = item.Amount;
                existingPayment.Date = item.Date;
                _repository.Update(existingPayment);
                return "Payment updated successfully.";
            }
            else
            {
                return "Payment not found.";
            }
        }

        public string Delete(Guid id)
        {
            var result = _repository.Delete(id);
            if (result)
                return "Payment deleted successfully.";
            else
                return "Payment not found.";
        }
    }
}
