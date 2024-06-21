using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;
using Restaurant_Site.server.Repository;

namespace Restaurant_Site.server.Services
{
    public class CustomerService: ICustomerService
    {
        ISQLRepository<Customer> _repository;

        public CustomerService(ISQLRepository<Customer> repository)
        {
            _repository = repository;
        }

        public IQueryable<Customer> GetAll()
        {
            return _repository.GetAll();
        }
        public IQueryable<Customer> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<Customer> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public Customer TryCreate(Customer item, out string message)
        {
            if (string.IsNullOrEmpty(item.FirstName) || string.IsNullOrEmpty(item.LastName) ||
                string.IsNullOrEmpty(item.Address))
            {
                message = "The name or description is be empty!";
                return default;
            }
            else
            {
                return _repository.TryCreate(item, out message);
            }
        }

        public bool TryUpdate(Guid id, Customer item, out string message)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is null)
            {
                message = "Item not found";
                return false;
            }
            else
            {
                _item.FirstName = item.FirstName;
                _item.LastName = item.LastName;
                _item.Address = item.Address;
                _item.ContactInfo = item.ContactInfo;
                _item.Username = item.Username;
                _item.Password = item.Password;

                return _repository.TryUpdate(_item, out message);
            }

        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }
    }
}


