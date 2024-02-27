using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;
using Restaurant_Site.Services;
using System.Net;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;
        private readonly ILogger<MenuController> _logger;

        public MenuController(IMenuService menuService, ILogger<MenuController> logger)
        {
            _menuService = menuService;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Menu>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            _logger.LogDebug("API started...");
            try
            {
                var menus = _menuService.GetAll();
                _logger.LogInformation("API finished...");
                return Ok(menus);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Menu), (int)HttpStatusCode.OK)]
        public IActionResult Get(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var menu = _menuService.GetById(id);
            if (menu == null)
                return NotFound();

            return Ok(menu);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Menu), (int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody] Menu menu)
        {
            if (menu == null)
                return BadRequest();

            _menuService.Create(menu);
            return CreatedAtAction(nameof(Get), new { id = menu.Id }, menu);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Put(Guid id, [FromBody] Menu menu)
        {
            if (id == Guid.Empty || menu == null)
                return BadRequest();

            var result = _menuService.Update(id, menu);
            if (result == "Menu not found.")
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Delete(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var result = _menuService.Delete(id);
            if (result == "Menu not found.")
                return NotFound();

            return Ok(result);
        }
    }

}
