using Restaurant_Site.Models;
using Restaurant_Site.Repository;

//using Restaurant_Site.Repositories;
using System;
using System.Linq;

namespace Restaurant_Site.Services
{
    public class DishService : IDishService
    {
         ISQLRepository<Dish> _repository;

        public DishService(ISQLRepository<Dish> repository)
        {
            _repository = repository;
        }

        public IQueryable<Dish> GetAll()
        {
            return _repository.GetAll();
        }

        public Dish GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Create(Dish item)
        {
            _repository.Create(item);
            return $"Created new dish with this ID: {item.Id}";
        }

        public string Update(Guid id, Dish item)
        {
            var existingDish = _repository.GetById(id);
            if (existingDish != null)
            {
                existingDish.Name = item.Name;
                existingDish.Description = item.Description;
                existingDish.Price = item.Price;
                _repository.Update(existingDish);
                return "Dish updated successfully.";
            }
            else
            {
                return "Dish not found.";
            }
        }

        public string Delete(Guid id)
        {
            var result = _repository.Delete(id);
            if (result)
                return "Dish deleted successfully.";
            else
                return "Dish not found.";
        }
    }
}
