using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models.finances;

namespace Restaurant_Site.server.IServices.IFinanceServices
{
    public interface IFinancialTransactionService: IBaseService<FinancialTransaction>
    {
        IEnumerable<FinancialTransaction> GetTransactionsInPeriod(DateTime startDate, DateTime endDate);
        decimal GetTotalTransactionAmountInPeriod(DateTime startDate, DateTime endDate);
    }
}
