using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.Controllers;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ICartService _cartService;

        public OrderController(IOrderService orderService, ICartService cartService)
        {
            _orderService = orderService;
            _cartService = cartService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateOrder()
        {
            var cart = _cartService.GetCart();
            var order = new Order
            {
                OrderDetails = cart.Items.Select(item => new OrderDetail
                {
                    ProductId = item.ProductId,
                  /*  CustomerId = it,*/
                    Quantity = item.Quantity,
                 /*   Price = item.Price*/
                }).ToList(),
              /*  TotalPrice = cart.TotalPrice*/
            };

            var orderId = await _orderService.CreateOrder(order);
            _cartService.ClearCart();
            return Ok(orderId);
        }

        [HttpGet("{orderId}")]
        public async Task<ActionResult<Order>> GetOrder(Guid orderId)
        {
            var order = await _orderService.GetOrder(orderId);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            var orders = await _orderService.GetOrders();
            return Ok(orders);
        }
    }
}
