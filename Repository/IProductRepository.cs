using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
        Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId);
    }
}
