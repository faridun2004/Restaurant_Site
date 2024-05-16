using Restaurant_Site.IServices.IFinanceServices;
using Restaurant_Site.Models;
using Restaurant_Site.Models.finances;
using Restaurant_Site.Repository;

namespace Restaurant_Site.Services.FinanceServices
{
    public class ExpenseService : IExpenseService
    {
        ISQLRepository<Expense> _repository;

        public ExpenseService(ISQLRepository<Expense> repository)
        {
            _repository = repository;
        }

        public IQueryable<Expense> GetAll()
        {
            return _repository.GetAll();
        }
        public IQueryable<Expense> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<Expense> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public Expense TryCreate(Expense item, out string message)
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

        public bool TryUpdate(Guid id, Expense item, out string message)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is null)
            {
                message = "Item not found";
                return false;
            }
            else
            {
                _item.Description = item.Description;
                _item.Amount=item.Amount;
                _item.ExpenseDateTime = item.ExpenseDateTime;
                _item.Category = item.Category;

                return _repository.TryUpdate(_item, out message);
            }

        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }
        public IEnumerable<Expense> GetExpensesInPeriod(DateTime startDate, DateTime endDate)
        {
            return _repository.GetAll().Where(e => e.ExpenseDateTime >= startDate && e.ExpenseDateTime <= endDate);
        }

        public decimal GetTotalExpensesInPeriod(DateTime startDate, DateTime endDate)
        {
            return _repository.GetAll().Where(e => e.ExpenseDateTime >= startDate && e.ExpenseDateTime <= endDate).Sum(e => e.Amount);
        }
    }

}
