using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;
using Restaurant_Site.Services;
using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.Extensions.Logging;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DishController : ControllerBase
    {
         readonly IDishService _dishService;
         readonly ILogger<DishController> _logger;

        public DishController(IDishService dishService, ILogger<DishController> logger)
        {
            _dishService = dishService;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Dish>), (int)HttpStatusCode.OK)]
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

            return Ok(_dishService.GetAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Dish), (int)HttpStatusCode.OK)]
        public IActionResult Get(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var dish = _dishService.GetById(id);
            if (dish == null)
                return NotFound();

            return Ok(dish);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Dish), (int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody] Dish dish)
        {
            if (dish == null)
                return BadRequest();

            _dishService.Create(dish);
            return CreatedAtAction(nameof(Get), new { id = dish.Id }, dish);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Put(Guid id, [FromBody] Dish dish)
        {
            if (id == Guid.Empty || dish == null)
                return BadRequest();

            var result = _dishService.Update(id, dish);
            if (result == "Dish not found.")
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Delete(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var result = _dishService.Delete(id);
            if (result == "Dish not found.")
                return NotFound();

            return Ok(result);
        }
    }
}
