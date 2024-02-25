using Restaurant_Site.Models;
using Restaurant_Site.Repository;

//using Restaurant_Site.Repositories;
using System;
using System.Linq;

namespace Restaurant_Site.Services
{
    public class InventoryService : IInventoryService
    {
        private ISQLRepository<Inventory> _repository;

        public InventoryService(ISQLRepository<Inventory> repository)
        {
            _repository = repository;
        }

        public IQueryable<Inventory> GetAll()
        {
            return _repository.GetAll();
        }

        public Inventory GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Create(Inventory item)
        {
            _repository.Create(item);
            return $"Created new inventory item with this ID: {item.Id}";
        }

        public string Update(Guid id, Inventory item)
        {
            var existingInventory = _repository.GetById(id);
            if (existingInventory != null)
            {
                existingInventory.Name = item.Name;
                existingInventory.Quantity = item.Quantity;
                _repository.Update(existingInventory);
                return "Inventory item updated successfully.";
            }
            else
            {
                return "Inventory item not found.";
            }
        }

        public string Delete(Guid id)
        {
            var result = _repository.Delete(id);
            if (result)
                return "Inventory item deleted successfully.";
            else
                return "Inventory item not found.";
        }
    }
}
