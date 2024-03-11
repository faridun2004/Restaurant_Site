using Restaurant_Site.Models;

namespace Restaurant_Site.IServices
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(Guid id);
        string Create(TEntity allItem);
        string Update(Guid id, TEntity item);
        string Delete(Guid id);
    }
}
