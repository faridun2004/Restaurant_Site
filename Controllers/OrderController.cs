using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Controllers;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.Controllers
{
    [ApiController]
    [Route("Order")]
    public class OrderController : BaseController<Order>
    {
        public OrderController(ILogger<OrderController> logger, IOrderService service) :
        base(logger, service)
        { }
    }
}
