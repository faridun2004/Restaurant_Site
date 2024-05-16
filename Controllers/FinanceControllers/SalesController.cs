using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.CQRS.Queries;
using Restaurant_Site.Models.finances;

namespace Restaurant_Site.Controllers.FinanceControllers
{
    [Authorize(Roles = "manager")]
    [ApiController]
    [Route("Sales")]
    public class SalesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SalesController(IMediator mediator) 
        { 
            _mediator = mediator;
        }
        [HttpGet("AllSales")] 
        public async Task<ActionResult<List<Sale>>> GetAll() 
        {
            var query = new GetAllProductsQuery();
            var products = await _mediator.Send(query);
            return Ok(products);
        }
        [HttpGet("GetSalesById")]
        public async Task<ActionResult<List<Sale>>> GetById(Guid id)
        {
            var query = new GetAllProductsQuery();
            var products = await _mediator.Send(query);
            return Ok(products);
        }


    }
}
