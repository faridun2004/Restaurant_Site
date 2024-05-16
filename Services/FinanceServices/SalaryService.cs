using Restaurant_Site.IServices.IFinanceServices;
using Restaurant_Site.Models;
using Restaurant_Site.Models.finances;
using Restaurant_Site.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

public class SalaryService : ISalaryService
{
     ISQLRepository<Salary> _repository;

    public SalaryService(ISQLRepository<Salary> repository)
    {
        _repository = repository;
    }

    public IQueryable<Salary> GetAll()
    {
        return _repository.GetAll();
    }

    public IQueryable<Salary> GetAll(int skip, int take)
    {
        return _repository.GetAll().Skip(skip).Take(take);
    }
    public IEnumerable<Salary> GetSalariesForEmployee(Guid employeeId)
    {
        return _repository.GetAll().Where(s => s.EmployeeId == employeeId);
    }

    public async Task<Salary> GetById(Guid id)
    {
        return await _repository.GetById(id);
    }

    public Salary TryCreate(Salary item, out string message)
    {
        if (string.IsNullOrEmpty(item.Amount.ToString()) || string.IsNullOrEmpty(item.SalaryDateTime.ToString()))
        {
            message = "The name or description is be empty!";
            return default;
        }
        else
        {
            return _repository.TryCreate(item, out message);
        }
    }

    public bool TryUpdate(Guid id, Salary item, out string message)
    {
        var _item = _repository.GetById(id).GetAwaiter().GetResult();
        if (_item is null)
        {
            message = "Item not found";
            return false;
        }
        else
        {
            _item.Amount = item.Amount;
            _item.SalaryDateTime = item.SalaryDateTime;
            _item.EmployeeId = item.EmployeeId;

            return _repository.TryUpdate(_item, out message);
        }

    }
    public bool TryDelete(Guid id, out string message)
    {
        return _repository.TryDelete(id, out message);
    }
}
