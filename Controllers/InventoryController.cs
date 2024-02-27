using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;
using Restaurant_Site.Services;
using System.Net;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;
        private readonly ILogger<InventoryController> _logger;

        public InventoryController(IInventoryService inventoryService, ILogger<InventoryController> logger)
        {
            _inventoryService = inventoryService;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Inventory>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            _logger.LogDebug("API started...");
            try
            {
                throw new Exception("Test exception");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
            }

            _logger.LogInformation("API finished...");

            return Ok(_inventoryService.GetAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Inventory), (int)HttpStatusCode.OK)]
        public IActionResult Get(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var inventory = _inventoryService.GetById(id);
            if (inventory == null)
                return NotFound();

            return Ok(inventory);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Inventory), (int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody] Inventory inventory)
        {
            if (inventory == null)
                return BadRequest();

            _inventoryService.Create(inventory);
            return CreatedAtAction(nameof(Get), new { id = inventory.Id }, inventory);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Put(Guid id, [FromBody] Inventory inventory)
        {
            if (id == Guid.Empty || inventory == null)
                return BadRequest();

            var result = _inventoryService.Update(id, inventory);
            if (result == "Inventory not found.")
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Delete(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var result = _inventoryService.Delete(id);
            if (result == "Inventory not found.")
                return NotFound();

            return Ok(result);
        }
    }

}
