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
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ILogger<OrderController> _logger;

        public OrderController(IOrderService orderService, ILogger<OrderController> logger)
        {
            _orderService = orderService;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Order>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            _logger.LogDebug("API started...");
            try
            {
                // Ваша логика здесь, если необходимо
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
            }

            _logger.LogInformation("API finished...");

            return Ok(_orderService.GetAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Order), (int)HttpStatusCode.OK)]
        public IActionResult Get(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var order = _orderService.GetById(id);
            if (order == null)
                return NotFound();

            return Ok(order);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Order), (int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody] Order order)
        {
            if (order == null)
                return BadRequest();

            return CreatedAtAction(nameof(Get), new { id = order.Id }, order);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Delete(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var result = _orderService.Delete(id);
            if (result == "Order not found.")
                return NotFound();

            return Ok(result);
        }
    }
}
