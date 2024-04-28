using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.Repository;
using System;
using System.Linq;

namespace Restaurant_Site.Services
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
        public Order GetById(Guid id)
        {
            return _repository.GetById(id);
        }
        public string Create(Order item)
        {
            // Ваша логика валидации и обработки создания заказа
            _repository.Create(item);
            return $"Created new item with this ID: {item.Id}";
        }
        public string Update(Guid id, Order item)
        {
            // Ваша логика обновления заказа
            var existingOrder = _repository.GetById(id);
            if (existingOrder != null)
            {
                // Обновляем данные заказа
                existingOrder.products = item.products;
                existingOrder.customer = item.customer;
                existingOrder.table = item.table;
                existingOrder.status = item.status;
                // Сохраняем обновленные данные в репозитории
                _repository.Update(existingOrder);
                return "Order updated successfully.";
            }
            else
            {
                return "Order not found.";
            }
        }
        public string Delete(Guid id)
        {
            // Ваша логика удаления заказа
            var result = _repository.Delete(id);
            if (result)
                return "Order deleted successfully.";
            else
                return "Order not found.";
        }
    }
}