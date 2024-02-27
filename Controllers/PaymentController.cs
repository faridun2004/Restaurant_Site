using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;
using Restaurant_Site.Services;
using System.Net;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(IPaymentService paymentService, ILogger<PaymentController> logger)
        {
            _paymentService = paymentService;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Payment>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            _logger.LogDebug("API started...");
            try
            {
                var payments = _paymentService.GetAll().ToList();
                _logger.LogInformation("API finished...");
                return Ok(payments);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Payment), (int)HttpStatusCode.OK)]
        public IActionResult Get(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var payment = _paymentService.GetById(id);
            if (payment == null)
                return NotFound();

            return Ok(payment);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Payment), (int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody] Payment payment)
        {
            if (payment == null)
                return BadRequest();

            var result = _paymentService.Create(payment);
            return CreatedAtAction(nameof(Get), new { id = payment.Id }, payment);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Put(Guid id, [FromBody] Payment payment)
        {
            if (id == Guid.Empty || payment == null)
                return BadRequest();

            var result = _paymentService.Update(id, payment);
            if (result == "Payment not found.")
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Delete(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var result = _paymentService.Delete(id);
            if (result == "Payment not found.")
                return NotFound();

            return Ok(result);
        }
    }
}
