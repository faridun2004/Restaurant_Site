using Restaurant_Site.Models;
using Restaurant_Site.server.Infrastructure;


namespace Restaurant_Site.Repository
{
    public interface ISQLRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        Task<T> GetById(Guid id);
        T TryCreate(T item, out string message);
        bool TryUpdate(T item, out string message);
        bool TryDelete(Guid id, out string message);
        IRestaurantContext GetContext();
     
    }
}
