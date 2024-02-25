using Restaurant_Site.Models;

namespace Restaurant_Site.Services
{
    public interface IInventoryService
    {

        IQueryable<Inventory> GetAll();
        Inventory GetById(Guid id);
        string Create(Inventory item);
        string Update(Guid id, Inventory item);
        string Delete(Guid id);
    }
}
