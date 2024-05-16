using Restaurant_Site.IServices;
using Restaurant_Site.Models.finances;

namespace Restaurant_Site.server.IServices.IFinanceServices
{
    public interface IExpenseCategoryService: IBaseService<ExpenseCategory>
    {
        IEnumerable<ExpenseCategory> GetAllCategoriesWithExpenses();
    }
}
