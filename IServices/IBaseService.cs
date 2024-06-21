using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.IServices
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(Guid id);
        TEntity TryCreate(TEntity item, out string message);
        bool TryUpdate(Guid id, TEntity item, out string message);
        bool TryDelete(Guid id, out string message);
    }
}   
