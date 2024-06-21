using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.Models;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductCategoriesController : ControllerBase
    {
        private readonly IProductCategoryService _categoryService;

        public ProductCategoriesController(IProductCategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] ProductCategoryCreateDto categoryCreateDto)
        {
            var category = new ProductCategory
            {
                Name = categoryCreateDto.Name,
                Description = categoryCreateDto.Description,
                Products = new List<Product>()
            };

            await _categoryService.CreateCategoryAsync(category);
            return CreatedAtAction(nameof(GetCategoryById), new { id = category.Id }, category);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
    }
}
