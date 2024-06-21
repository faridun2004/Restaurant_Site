using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.IServices
{
    public interface IProductCategoryService
    {
        Task CreateCategoryAsync(ProductCategory category);
        Task<ProductCategory?> GetCategoryByIdAsync(int id);
    }
}
