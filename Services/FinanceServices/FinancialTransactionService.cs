using Restaurant_Site.Models.finances;
using Restaurant_Site.Repository;
using Restaurant_Site.server.IServices.IFinanceServices;

namespace Restaurant_Site.server.Services.FinanceServices
{
    public class FinancialTransactionService : IFinancialTransactionService
    {
        ISQLRepository<FinancialTransaction> _repository;

        public FinancialTransactionService(ISQLRepository<FinancialTransaction> repository)
        {
            _repository = repository;
        }

        public IQueryable<FinancialTransaction> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<FinancialTransaction> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public FinancialTransaction TryCreate(FinancialTransaction item, out string message)
        {
            if (string.IsNullOrEmpty(item.Description) || string.IsNullOrEmpty(item.Amount.ToString()))
            {
                message = "The name or description is be empty!";
                return default;
            }
            else
            {
                return _repository.TryCreate(item, out message);
            }
        }

        public bool TryUpdate(Guid id, FinancialTransaction item, out string message)
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
                _item.TransactionDateTime = item.TransactionDateTime;
                _item.Description = item.Description;

                return _repository.TryUpdate(_item, out message);
            }

        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }
        public IEnumerable<FinancialTransaction> GetTransactionsInPeriod(DateTime startDate, DateTime endDate)
        {
            return _repository.GetAll().Where(t => t.TransactionDateTime >= startDate && t.TransactionDateTime <= endDate);
        }
        public decimal GetTotalTransactionAmountInPeriod(DateTime startDate, DateTime endDate)
        {
            return _repository.GetAll().Where(t => t.TransactionDateTime >= startDate && t.TransactionDateTime <= endDate).Sum(t => t.Amount);
        }
    }

}
