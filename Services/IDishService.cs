using Restaurant_Site.Models;

namespace Restaurant_Site.Services
{
    public interface IDishService
    {
        IQueryable<Dish> GetAll();
        Dish GetById(Guid id);
        string Create(Dish item);
        string Update(Guid id, Dish item);
        string Delete(Guid id);
    }
}
