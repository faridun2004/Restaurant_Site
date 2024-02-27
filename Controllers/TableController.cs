using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Restaurant_Site.Models;
using Restaurant_Site.Services;
using System.Net;
using Table = Restaurant_Site.Models.Table;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("Table")]
    public class TableController : ControllerBase
    {
        readonly ITableService _service;
        readonly ILogger<TableController> _logger;

        public TableController(ILogger<TableController> logger, ITableService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Table>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            _logger.LogDebug("API started...");
            try
            {
                throw new Exception("Test exception");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Started Exception...{ex.Message}");
            }

            _logger.LogInformation("API finished...");

            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Table), (int)HttpStatusCode.OK)]
        public IActionResult Get(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public Table Post([FromBody] Table item)
        {
            _service.Create(item);
            return item;
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] Table item)
        {
            return _service.Update(id, item);
        }

        [HttpDelete("Delete")]
        public string Delete([FromQuery] Guid id)
        {
            return _service.Delete(id);
        }
    }
}
