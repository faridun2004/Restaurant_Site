using Microsoft.EntityFrameworkCore;
using Restaurant_Site.Models;
using Restaurant_Site.Models.finances;
using Restaurant_Site.Repository;
using Restaurant_Site.server.IServices.IFinanceServices;

namespace Restaurant_Site.server.Services.FinanceServices
{
    public class ExpenseCategoryService : IExpenseCategoryService
    {
        ISQLRepository<ExpenseCategory> _repository;

        public ExpenseCategoryService(ISQLRepository<ExpenseCategory> repository)
        {
            _repository = repository;
        }

        public IQueryable<ExpenseCategory> GetAll()
        {
            return _repository.GetAll();
        }
        public IQueryable<ExpenseCategory> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<ExpenseCategory> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public ExpenseCategory TryCreate(ExpenseCategory item, out string message)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                message = "The name or description is be empty!";
                return default;
            }
            else
            {
                return _repository.TryCreate(item, out message);
            }
        }

        public bool TryUpdate(Guid id, ExpenseCategory item, out string message)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is null)
            {
                message = "Item not found";
                return false;
            }
            else
            {
                _item.Name = item.Name;
                _item.Expenses = item.Expenses;

                return _repository.TryUpdate(_item, out message);
            }

        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }

        // Дополнительные методы для работы с категориями расходов
        public IEnumerable<ExpenseCategory> GetAllCategoriesWithExpenses()
        {
            return _repository.GetAll().Include(e => e.Expenses);
        }
    }

}
