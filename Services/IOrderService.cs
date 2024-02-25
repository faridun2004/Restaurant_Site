using Restaurant_Site.Models;

namespace Restaurant_Site.Services
{
    public interface IOrderService
    {
        IQueryable<Order> GetAll();
        Order GetById(Guid id);
        string Create(Order order);
        string Update(Guid id, Order item);
        string Delete(Guid id);
       
        //void PlaceOrder(Order order);
        //string UpdateOrderStatus(Guid id, OrderStatus status);
    }
}
