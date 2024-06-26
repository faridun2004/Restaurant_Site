using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.CQRS.Queries;
using Restaurant_Site.server.IServices.IFinanceServices;
using Restaurant_Site.server.Models.finances;

namespace Restaurant_Site.server.Controllers.FinanceControllers
{
    [Authorize(Roles ="Manager")]
    [ApiController]
    [Route("api/[controller]")]
    public class SalesController : ControllerBase
    {
        private readonly ISaleService _saleService;

        public SalesController(ISaleService saleService)
        {
            _saleService = saleService;
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetAllSales()
        {
            var sales = _saleService.GetAllSales();
            return Ok(sales);
        }
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSaleById(Guid id)
        {
            var sale = await _saleService.GetSaleById(id);
            if (sale == null)
            {
                return NotFound();
            }
            return Ok(sale);
        }

        [HttpPost]
        public IActionResult CreateSale(Sale sale)
        {
            string message;
            var createdSale = _saleService.TryCreateSale(sale, out message);
            if (createdSale == null)
            {
                return BadRequest(message);
            }
            return CreatedAtAction(nameof(GetSaleById), new { id = createdSale.Id }, createdSale);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSale(Guid id, Sale sale)
        {
            if (id != sale.Id)
            {
                return BadRequest("Sale ID mismatch");
            }

            string message;
            var success = _saleService.TryUpdateSale(sale, out message);
            if (!success)
            {
                return BadRequest(message);
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSale(Guid id)
        {
            string message;
            var success = _saleService.TryDeleteSale(id, out message);
            if (!success)
            {
                return BadRequest(message);
            }
            return NoContent();
        }
    }
}
