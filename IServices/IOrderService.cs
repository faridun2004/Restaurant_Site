using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.IServices
{
    public interface IOrderService 
    {
        Task<Guid> CreateOrder(Order order);
        Task<Order> GetOrder(Guid orderId);
        Task<IEnumerable<Order>> GetOrders();
    }
}
