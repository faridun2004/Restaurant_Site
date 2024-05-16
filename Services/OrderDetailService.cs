using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.Repository;
using Restaurant_Site.server.Models;
using System;
using System.Linq;

namespace Restaurant_Site.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        ISQLRepository<OrderDetail> _repository;

        public OrderDetailService(ISQLRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public IQueryable<OrderDetail> GetAll()
        {
            return _repository.GetAll();
        }
        public IQueryable<OrderDetail> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<OrderDetail> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public OrderDetail TryCreate(OrderDetail item, out string message)
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

        public bool TryUpdate(Guid id, OrderDetail item, out string message)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is null)
            {
                message = "Item not found";
                return false;
            }
            else
            {
                _item.Product = item.Product;
                _item.Quantity = item.Quantity;
                _item.status = item.status;
                _item.Order= item.Order;
                _item.Customer= item.Customer;
                _item.Employee= item.Employee;  
                _item.Table= item.Table;

                return _repository.TryUpdate(_item, out message);
            }

        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }
    }
}