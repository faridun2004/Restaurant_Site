using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;
using Restaurant_Site.IServices;
using MediatR;
using Restaurant_Site.CQRS.Commands;
using Restaurant_Site.CQRS.Queries;
using Microsoft.AspNetCore.Authorization;
namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("AllProducts")]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var query = new GetAllProductsQuery();
            var products = await _mediator.Send(query);
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(Guid id)
        {
            var query = new GetProductByIdQuery() { Id = id };
            var product = await _mediator.Send(query);
            if (product == null)
                return NotFound();

            return Ok(product);
        }
        [HttpPost]
        public async Task<ActionResult<Product>> Createproduct(CreateProductCommand command)
        {
            var (createdItem, message)=await _mediator.Send(command);
            if(createdItem is null)
                return BadRequest(message);
            return Ok(createdItem);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<string>> UpdateProduct(Guid id, UpdateProductCommand command)
        {
            command.ProductId = id;
            var (result, message) = await _mediator.Send(command);
            if (result)
                return Ok(message);

            return BadRequest(message);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(DeleteProductCommand deleteProduct)
        {
            var (result, message) = await _mediator.Send(deleteProduct);
            if (result)
                return Ok(message);

            return BadRequest(message);
        }
    }
}