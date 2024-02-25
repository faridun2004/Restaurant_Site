using Restaurant_Site.Models;

namespace Restaurant_Site.Services
{
    public interface ITableService
    {
        IQueryable<Table> GetAll();
        Table GetById(Guid id);
        string Create(Table item);
        string Update(Guid id, Table item);
        string Delete(Guid id);
    }
}
