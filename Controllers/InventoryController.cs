using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;
using Restaurant_Site.Services;
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
