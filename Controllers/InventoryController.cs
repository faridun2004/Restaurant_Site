using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;
using System.Net;

namespace Restaurant_Site.server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : BaseController<Inventory>
    {
        public InventoryController(ILogger<InventoryController> logger, IInventoryService service) : base(logger, service)
        { }
    }
}
