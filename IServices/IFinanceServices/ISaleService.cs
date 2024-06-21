using Restaurant_Site.server.Models.finances;

namespace Restaurant_Site.server.IServices.IFinanceServices
{
    public interface ISaleService 
    {
        IQueryable<Sale> GetAllSales();
        Task<Sale> GetSaleById(Guid id);
        Sale TryCreateSale(Sale sale, out string message);
        bool TryUpdateSale(Sale sale, out string message);
        bool TryDeleteSale(Guid id, out string message);
    }
}
