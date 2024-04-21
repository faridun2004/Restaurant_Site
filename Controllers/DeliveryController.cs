using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;

namespace Restaurant_Site.Controllers
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
