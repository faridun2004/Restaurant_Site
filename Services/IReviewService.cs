using Restaurant_Site.Models;

namespace Restaurant_Site.Services
{
    public interface IReviewService
    {
        IQueryable<Review> GetAll();
        Review GetById(Guid id);
        string Create(Review worker);
        string Update(Guid id, Review item);
        string Delete(Guid id);
    }
}
