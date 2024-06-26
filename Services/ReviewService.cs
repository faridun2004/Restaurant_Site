using Amazon.Runtime.SharedInterfaces;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;
using Restaurant_Site.server.Repository;


namespace Restaurant_Site.server.Services
{
    public class ReviewService: IReviewService
    {
        ISQLRepository<Review> _repository;
        public ReviewService(ISQLRepository<Review> repository)
        {
            _repository = repository;
        }

        public IQueryable<Review> GetAll()
        {
            return _repository.GetAll();
        }
        public IQueryable<Review> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<Review> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }
      
        public Review TryCreate(Review item, out string message)
        {
            if (string.IsNullOrEmpty(item.Comment))
            {
                message= "The name cannot be empty";
                return default;
            }
            return _repository.TryCreate(item, out message);
            
        }
       
        public bool TryUpdate(Guid id, Review item, out string message)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (item is null)
            {
                message = "Items not found";
                return false;
            }
            else
            {
                _item.Comment=item.Comment;
                _item.Rating=item.Rating;

                return _repository.TryUpdate(_item,out message);
            }
        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }
    }
}

