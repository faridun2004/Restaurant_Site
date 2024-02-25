using Restaurant_Site.Models;

namespace Restaurant_Site.Services
{
    public interface IMenuService
    {
        IQueryable<Menu> GetAll();
        Menu GetById(Guid id);
        string Create(Menu customer);
        string Update(Guid id, Menu item);
        string Delete(Guid id);
    }
}
