using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Restaurant_Site.Models;
using Restaurant_Site.Services;
using System.Net;
using Table = Restaurant_Site.Models.Table;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class TableController : BaseController<Table>
    {
        public TableController(ILogger<TableController> logger, ITableService service): 
            base(logger,service)
        {  }
    }
}
