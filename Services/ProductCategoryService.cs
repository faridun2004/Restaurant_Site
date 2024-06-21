using Microsoft.EntityFrameworkCore;
using Restaurant_Site.Infrastructure;
using Restaurant_Site.server.Infrastructure;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.Services
{
    public class ProductCategoryService: IProductCategoryService
    {
        private readonly RestaurantContext _context;

        public ProductCategoryService(RestaurantContext context)
        {
            _context = context;
        }

        public async Task CreateCategoryAsync(ProductCategory category)
        {
            _context.ProductCategories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task<ProductCategory?> GetCategoryByIdAsync(int id)
        {
            return await _context.ProductCategories.Include(c => c.Products).FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
