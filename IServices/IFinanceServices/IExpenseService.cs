using Restaurant_Site.Models.finances;

namespace Restaurant_Site.IServices.IFinanceServices
{
    public interface IExpenseService: IBaseService<Expense>
    {
        IEnumerable<Expense> GetExpensesInPeriod(DateTime startDate, DateTime endDate);
        decimal GetTotalExpensesInPeriod(DateTime startDate, DateTime endDate);
    }
}
