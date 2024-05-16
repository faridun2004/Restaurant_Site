using Restaurant_Site.IServices;
using Restaurant_Site.Models.finances;

namespace Restaurant_Site.server.IServices.IFinanceServices
{
    public interface IFinancialTransactionService: IBaseService<FinancialTransaction>
    {
        IEnumerable<FinancialTransaction> GetTransactionsInPeriod(DateTime startDate, DateTime endDate);
        decimal GetTotalTransactionAmountInPeriod(DateTime startDate, DateTime endDate);
    }
}
