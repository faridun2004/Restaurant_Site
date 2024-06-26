using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryController : BaseController<Delivery>
    {

        public DeliveryController(ILogger<DeliveryController> logger, IDeliveryService service) 
            : base(logger, service)
        {
        }
    }
}
