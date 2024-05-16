using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.Repository;

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
        public IQueryable<Menu> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<Menu> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public Menu TryCreate(Menu item, out string message)
        {
            if (string.IsNullOrEmpty(item.ProductId.ToString()))
            {
                message = "The name or description is be empty!";
                return default;
            }
            else
            {
                return _repository.TryCreate(item, out message);
            }
        }

        public bool TryUpdate(Guid id, Menu item, out string message)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is null)
            {
                message = "Item not found";
                return false;
            }
            else
            {
                _item.ProductId = item.ProductId;

                return _repository.TryUpdate(_item, out message);
            }

        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }
    }
}
