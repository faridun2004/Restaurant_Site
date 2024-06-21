using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.IServices;
using Table = Restaurant_Site.server.Models.Table;

namespace Restaurant_Site.server.Controllers
{
    [ApiController]
    [Route("Table")]
    public class TableController : BaseController<Table>
    {
        public TableController(ILogger<TableController> logger, ITableService service): 
            base(logger,service)
        {  }
    }
}
