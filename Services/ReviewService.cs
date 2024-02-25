using Restaurant_Site.Models;
using Restaurant_Site.Repository;


namespace Restaurant_Site.Services
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

        public Review GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Create(Review item)
        {
            if (string.IsNullOrEmpty(item.Comment))
            {
                return "The name cannot be empty";
            }
            else
            {
                _repository.Create(item);
                return $"Created new item with this ID: {item.Id}";
            }
        }

        public string Update(Guid id, Review item)
        {
            var _item = _repository.GetById(id);
            if (_item is not null)
            {
                _item.Comment = item.Comment;
                _item.Rating = item.Rating;
               
                var result = _repository.Update(_item);
                if (result)
                    return "Item updated";
            }

            return "Item not updated";
        }

        public string Delete(Guid id)
        {
            var result = _repository.Delete(id);
            if (result)
                return "Item deleted";
            else
                return "Item not found";
        }
    }
}

