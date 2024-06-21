using Restaurant_Site.server.IServices.IFinanceServices;
using Restaurant_Site.server.Models;
using Restaurant_Site.server.Models.finances;
using Restaurant_Site.server.Repository;

public class SaleService : ISaleService
{
    private readonly ISQLRepository<Sale> _repository;

    public SaleService(ISQLRepository<Sale> repository)
    {
        _repository = repository;
    }

    public IQueryable<Sale> GetAllSales()
    {
        return _repository.GetAll();
    }

    public async Task<Sale> GetSaleById(Guid id)
    {
        return await _repository.GetById(id);
    }

    public Sale TryCreateSale(Sale sale, out string message)
    {
        return _repository.TryCreate(sale, out message);
    }

    public bool TryUpdateSale(Sale sale, out string message)
    {
        return _repository.TryUpdate(sale, out message);
    }

    public bool TryDeleteSale(Guid id, out string message)
    {
        return _repository.TryDelete(id, out message);
    }
}
