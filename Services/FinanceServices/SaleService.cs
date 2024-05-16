using Restaurant_Site.IServices.IFinanceServices;
using Restaurant_Site.Models;
using Restaurant_Site.Models.finances;
using Restaurant_Site.Repository;

public class SaleService : ISaleService
{
    private readonly ISQLRepository<Sale> _repository;

    public SaleService(ISQLRepository<Sale> repository)
    {
        _repository = repository;
    }

    public IQueryable<Sale> GetAll()
    {
        return _repository.GetAll();
    }
    public IQueryable<Sale> GetAll(int skip, int take)
    {
        return _repository.GetAll().Skip(skip).Take(take);
    }

    public async Task<Sale> GetById(Guid id)
    {
        return await _repository.GetById(id);
    }

    public IEnumerable<Sale> GetSalesForEmployee(Guid employeeId)
    {
        return _repository.GetAll().Where(s => s.EmployeeId == employeeId);
    }

    public IEnumerable<Sale> GetSalesInPeriod(DateTime startDate, DateTime endDate)
    {
        return _repository.GetAll().Where(s => s.SaleDateTime >= startDate && s.SaleDateTime <= endDate);
    }

    public decimal GetTotalSalesAmountForEmployee(Guid employeeId)
    {
        return _repository.GetAll().Where(s => s.EmployeeId == employeeId).Sum(s => s.TotalAmount);
    }

    public Sale TryCreate(Sale item, out string message)
    {
        if (string.IsNullOrEmpty(item.SaleDateTime.ToString()) || string.IsNullOrEmpty(item.TotalAmount.ToString()))
        {
            message = "The name or description is be empty!";
            return default;
        }
        else
        {
            return _repository.TryCreate(item, out message);
        }
    }

    public bool TryUpdate(Guid id, Sale item, out string message)
    {
        var _item = _repository.GetById(id).GetAwaiter().GetResult();
        if (_item is null)
        {
            message = "Item not found";
            return false;
        }
        else
        {
            _item.SaleDateTime = item.SaleDateTime;
            _item.TotalAmount = item.TotalAmount;
            _item.ProductsSold = item.ProductsSold;
            _item.EmployeeId= item.EmployeeId;

            return _repository.TryUpdate(_item, out message);
        }

    }
    public bool TryDelete(Guid id, out string message)
    {
        return _repository.TryDelete(id, out message);
    }
}
