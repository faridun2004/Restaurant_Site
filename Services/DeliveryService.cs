using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.Repository;

namespace Restaurant_Site.Services
{
    public class DeliveryService : IDeliveryService
    {
        private readonly ISQLRepository<Delivery> _repository;

        public DeliveryService(ISQLRepository<Delivery> repository)
        {
            _repository = repository;
        }

        public IQueryable<Delivery> GetAll()
        {
            return _repository.GetAll();
        }

        public Delivery GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Create(Delivery item)
        {
            _repository.Create(item);
            return $"Created new delivery with this ID: {item.Id}";
        }

        public string Update(Guid id, Delivery item)
        {
            var existingDelivery = _repository.GetById(id);
            if (existingDelivery != null)
            {
                // Update existing delivery properties here
                _repository.Update(existingDelivery);
                return "Delivery updated successfully.";
            }
            else
            {
                return "Delivery not found.";
            }
        }

        public string Delete(Guid id)
        {
            var result = _repository.Delete(id);
            if (result)
                return "Delivery deleted successfully.";
            else
                return "Delivery not found.";
        }
    }
}
