using Restaurant_Site.Models;

namespace Restaurant_Site.Repository
{
    public interface ISQLRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        T GetById(Guid id);
        bool Create(T item);
        bool Update(T item);
        bool Delete(Guid id);
        
    }
}
