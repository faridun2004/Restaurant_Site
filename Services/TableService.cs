using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.Repository;

namespace Restaurant_Site.Services
{
    public class TableService : ITableService
    {
        ISQLRepository<Table> _repository;

        public TableService(ISQLRepository<Table> repository)
        {
            _repository = repository;
        }

        public IQueryable<Table> GetAll()
        {
            return _repository.GetAll();
        }
        public IQueryable<Table> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<Table> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public Table TryCreate(Table item, out string message)
        {
            if (string.IsNullOrEmpty(item.Capacity))
            {
                message = "The name or description is be empty!";
                return default;
            }
            else
            {
                return _repository.TryCreate(item, out message);
            }
        }

        public bool TryUpdate(Guid id, Table item, out string message)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is null)
            {
                message = "Item not found";
                return false;
            }
            else
            {
                _item.Capacity = item.Capacity;

                return _repository.TryUpdate(_item, out message);
            }

        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }
    }
}
