using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;
using Restaurant_Site.IServices;
using MediatR;
using Restaurant_Site.CQRS.Commands;
using Restaurant_Site.CQRS.Queries;
namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : /*BaseController<Dish>*/  ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("AllProducts")]
        public async Task<ActionResult<List<Product>>> GetAllClients()
        {
            var query = new GetAllProductsQuery();
            var products = await _mediator.Send(query);
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetClientById(Guid id)
        {
            var query = new GetProductByIdQuery() { Id = id };
            var product = await _mediator.Send(query);
            if (product == null)
                return NotFound();

            return Ok(product);
        }
        [HttpPost]
        public async Task<ActionResult<Product>> CreateClient(CreateProductCommand command)
        {
            var product = await _mediator.Send(command);
            return Ok(product);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<string>> UpdateClient(Guid id, UpdateProductCommand command)
        {
            command.ProductId = id;
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(DeleteProductCommand deleteProduct)
        {
            var result = await _mediator.Send(deleteProduct);
            return Ok(result);
        }
    }
}