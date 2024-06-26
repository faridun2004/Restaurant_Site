using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;
using Restaurant_Site.server.Repository;

namespace Restaurant_Site.server.Services
{
    public class InventoryService : IInventoryService
    {
        ISQLRepository<Inventory> _repository;

        public InventoryService(ISQLRepository<Inventory> repository)
        {
            _repository = repository;
        }

        public IQueryable<Inventory> GetAll()
        {
            return _repository.GetAll();
        }
        public IQueryable<Inventory> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<Inventory> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public Inventory TryCreate(Inventory item, out string message)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                message = "The name or description is be empty!";
                return default;
            }
            else
            {
                return _repository.TryCreate(item, out message);
            }
        }

        public bool TryUpdate(Guid id, Inventory item, out string message)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is null)
            {
                message = "Item not found";
                return false;
            }
            else
            {
                _item.Name = item.Name;
                _item.Quantity = item.Quantity;

                return _repository.TryUpdate(_item, out message);
            }

        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }
    }
}
