using Restaurant_Site.server.Models.finances;

namespace Restaurant_Site.server.IServices.IFinanceServices
{
    public interface IExpenseService: IBaseService<Expense>
    {
        IEnumerable<Expense> GetExpensesInPeriod(DateTime startDate, DateTime endDate);
        decimal GetTotalExpensesInPeriod(DateTime startDate, DateTime endDate);
    }
}
