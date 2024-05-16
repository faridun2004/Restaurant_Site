using Restaurant_Site.Models;
using Restaurant_Site.Models.finances;
using Restaurant_Site.Repository;
using Restaurant_Site.server.IServices.IFinanceServices;

namespace Restaurant_Site.server.Services.FinanceServices
{
    public class CashRegisterService : ICashRegisterService
    {
        ISQLRepository<CashRegister> _repository;

        public CashRegisterService(ISQLRepository<CashRegister> repository)
        {
            _repository = repository;
        }

        public IQueryable<CashRegister> GetAll()
        {
            return _repository.GetAll();
        }
        public IQueryable<CashRegister> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<CashRegister> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public CashRegister TryCreate(CashRegister item, out string message)
        {
            if (string.IsNullOrEmpty(item.CashAmount.ToString()))
            {
                message = "The name or description is be empty!";
                return default;
            }
            else
            {
                return _repository.TryCreate(item, out message);
            }
        }

        public bool TryUpdate(Guid id, CashRegister item, out string message)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is null)
            {
                message = "Item not found";
                return false;
            }
            else
            {
                _item.CashAmount = item.CashAmount;
                _item.RegisterDateTime = item.RegisterDateTime;

                return _repository.TryUpdate(_item, out message);
            }

        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }
        public decimal GetTotalCashAmount()
        {
            return _repository.GetAll().Sum(c => c.CashAmount);
        }
    }
}
