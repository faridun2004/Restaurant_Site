using Restaurant_Site.Models;
using Restaurant_Site.Repository;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.Services
{
    public class OrderService : IOrderService
    {
        ISQLRepository<Order> _repository;

        public OrderService(ISQLRepository<Order> repository)
        {
            _repository = repository;
        }

        public IQueryable<Order> GetAll()
        {
            return _repository.GetAll();
        }
        public IQueryable<Order> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<Order> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public Order TryCreate(Order item, out string message)
        {
            if (string.IsNullOrEmpty(item.Id.ToString()))
            {
                message = "The name or description is be empty!";
                return default;
            }
            else
            {
                return _repository.TryCreate(item, out message);
            }
        }

        public bool TryUpdate(Guid id, Order item, out string message)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is null)
            {
                message = "Item not found";
                return false;
            }
            else
            {
                _item.OrderDetails = item.OrderDetails;

                return _repository.TryUpdate(_item, out message);
            }

        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }
    }
}
