using Microsoft.EntityFrameworkCore;
using Restaurant_Site.Infrastructure;
using Restaurant_Site.server.Infrastructure;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly RestaurantContext _context;

        public ProductRepository(RestaurantContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId)
        {
            return await _context.Products
                                 .Where(p => p.ProductCategoryId == categoryId)
                                 .ToListAsync();
        }
    }
}
