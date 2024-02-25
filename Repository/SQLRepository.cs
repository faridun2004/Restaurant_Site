using Microsoft.AspNetCore.Authentication;
using Restaurant_Site.Infrastructure;
using Restaurant_Site.Models;

namespace Restaurant_Site.Repository
{
    public class SQLRepository<T> : ISQLRepository<T> where T : BaseEntity
    {
        readonly RestaurantContext _context;
        public SQLRepository(RestaurantContext restaurantContext)
        {
            _context = restaurantContext;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(Guid id)
        {
            return  _context.Set<T>().SingleOrDefault(w => w.Id == id);
        }

        public bool Create(T item)
        {
            try
            {
                _context.Add(item);
                var result = _context.SaveChanges();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(T item)
        {
            try
            {
                _context.Update(item);
                var result = _context.SaveChanges();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var item = _context.Set<T>().SingleOrDefault(w => w.Id == id);
                if (item is not null)
                {
                    _context.Remove(item);
                    var result = _context.SaveChanges();
                    return result > 0;
                }
            }
            catch
            { }

            return false;
        }
    }
}

