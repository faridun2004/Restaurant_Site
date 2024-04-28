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

        [HttpPost]
        public async Task<ActionResult<Product>> CreateClient(CreateProductCommand command)
        {
            var user = await _mediator.Send(command);
            return Ok(user);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetClientById(Guid id)
        {
            var query = new GetProductByIdQuery() { Id = id };
            var client = await _mediator.Send(query);
            if (client == null)
                return NotFound();

            return Ok(client);
        }

        [HttpGet("AllProducts")]
        public async Task<ActionResult<List<Product>>> GetAllClients()
        {
            var query = new GetAllProductsQuery();
            var clients = await _mediator.Send(query);
            return Ok(clients);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> UpdateClient(Guid id, UpdateProductCommand command)
        {
            command.ProductId = id;
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(DeleteProductCommand deleteClient)
        {
            var result = await _mediator.Send(deleteClient);
            return Ok(result);
        }
    }
}