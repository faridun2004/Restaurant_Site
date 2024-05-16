using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.Repository;

namespace Restaurant_Site.Services
{
    public class DeliveryService : IDeliveryService
    {
        ISQLRepository<Delivery> _repository;

        public DeliveryService(ISQLRepository<Delivery> repository)
        {
            _repository = repository;
        }
        public IQueryable<Delivery> GetAll()
        {
            return _repository.GetAll();
        }
        public IQueryable<Delivery> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<Delivery> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public Delivery TryCreate(Delivery item, out string message)
        {
            if (string.IsNullOrEmpty(item.Address) || string.IsNullOrEmpty(item.ContactNumber))
            {
                message = "The name or description is be empty!";
                return default;
            }
            else
            {
                return _repository.TryCreate(item, out message);
            }
        }

        public bool TryUpdate(Guid id, Delivery item, out string message)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is null)
            {
                message = "Item not found";
                return false;
            }
            else
            {
                _item.DeliveryDateTime = item.DeliveryDateTime;
                _item.Address = item.Address;
                _item.ContactNumber = item.ContactNumber;
                _item.DeliveryFee= item.DeliveryFee;
                _item.OrderId= item.OrderId;

                return _repository.TryUpdate(_item, out message);
            }

        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }
    }
}

