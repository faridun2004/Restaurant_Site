using AutoMapper.Internal;
using Restaurant_Site.server.Models;
using Restaurant_Site.server.IServices;

namespace Restaurant_Site.server.Services
{
    public class OrderService : IOrderService
    {
        private readonly List<Order> _orders = new();

        public Task<Guid> CreateOrder(Order order)
        {
          /*  order.Id = _orders.Count +1;*/
            _orders.Add(order);
            return Task.FromResult(order.Id);
        }

        public Task<Order> GetOrder(Guid orderId)
        {
            var order = _orders.FirstOrDefault(o => o.Id == orderId);
            return Task.FromResult(order);
        }

        public Task<IEnumerable<Order>> GetOrders()
        {
            return Task.FromResult<IEnumerable<Order>>(_orders);
        }
    }
}
