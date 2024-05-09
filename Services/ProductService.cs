﻿using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.Repository;
namespace Restaurant_Site.Services
{
    public class ProductService : IProductService
    {
         ISQLRepository<Product> _repository;

        public ProductService(ISQLRepository<Product> repository)
        {
            _repository = repository;
        }

        public IQueryable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public Product GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Create(Product item)
        {
            _repository.Create(item);
            return $"Created new dish with this ID: {item.Id}";
        }

        public string Update(Guid id, Product item)
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