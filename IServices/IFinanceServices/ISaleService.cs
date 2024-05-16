using Restaurant_Site.Models.finances;

namespace Restaurant_Site.IServices.IFinanceServices
{
    public interface ISaleService : IBaseService<Sale>
    {
        IEnumerable<Sale> GetSalesForEmployee(Guid employeeId);
        IEnumerable<Sale> GetSalesInPeriod(DateTime startDate, DateTime endDate);
        decimal GetTotalSalesAmountForEmployee(Guid employeeId);
    }
}
