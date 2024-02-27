using Restaurant_Site.Models;
using Restaurant_Site.Repository;

//using Restaurant_Site.Repositories;
using System;
using System.Linq;

namespace Restaurant_Site.Services
{
    public class MenuService : IMenuService
    {
         ISQLRepository<Menu> _repository;

        public MenuService(ISQLRepository<Menu> repository)
        {
            _repository = repository;
        }

        public IQueryable<Menu> GetAll()
        {
            return _repository.GetAll();
        }

        public Menu GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Create(Menu item)
        {
            _repository.Create(item);
            return $"Created new menu with this ID: {item.Id}";
        }

        public string Update(Guid id, Menu item)
        {
            var existingMenu = _repository.GetById(id);
            if (existingMenu != null)
            {
                existingMenu.Dishes = item.Dishes;
                _repository.Update(existingMenu);
                return "Menu updated successfully.";
            }
            else
            {
                return "Menu not found.";
            }
        }

        public string Delete(Guid id)
        {
            var result = _repository.Delete(id);
            if (result)
                return "Menu deleted successfully.";
            else
                return "Menu not found.";
        }
    }
}
