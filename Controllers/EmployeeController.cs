using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;
using Restaurant_Site.Services;
using System.Net;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
        readonly IEmployeeService _service;
        readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Employee>), (int)HttpStatusCode.OK)]
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
        [ProducesResponseType(typeof(Employee), (int)HttpStatusCode.OK)]
        public IActionResult Get(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public Employee Post([FromBody] Employee item)
        {
            _service.Create(item);
            return item;
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] Employee item)
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
