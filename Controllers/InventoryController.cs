using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using System.Net;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : BaseController<Inventory>
    {
        public InventoryController(ILogger<InventoryController> logger, IInventoryService service) : base(logger, service)
        { }
    }
}
