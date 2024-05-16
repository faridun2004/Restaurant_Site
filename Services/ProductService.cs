using Restaurant_Site.IServices;
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
        public IQueryable<Product> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<Product> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public Product TryCreate(Product item, out string message)
        {
            if(string.IsNullOrEmpty(item.Name) || string.IsNullOrEmpty(item.Description)) 
            {
                message = "The name or description is be empty!";
                return default;
            }
            else
            {
                return _repository.TryCreate(item, out message);
            }
        }

        public bool TryUpdate(Guid id, Product item, out string message)
        {
            var _item=_repository.GetById(id).GetAwaiter().GetResult();
            if(_item is null)
            {
                message = "Item not found";
                return false;
            }
            else
            {
                _item.Name = item.Name;
                _item.Description = item.Description;
                _item.Price = item.Price;
                
                return _repository.TryUpdate(_item, out message);
            }
           
        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }
    }
}