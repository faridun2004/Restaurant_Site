using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;
using Restaurant_Site.server.Repository;

namespace Restaurant_Site.server.Services
{
    public class EventService: IEventService
    {
        ISQLRepository<Event> _repository;

        public EventService(ISQLRepository<Event> repository)
        {
            _repository = repository;
        }

        public IQueryable<Event> GetAll()
        {
            return _repository.GetAll();
        }
        public IQueryable<Event> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<Event> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public Event TryCreate(Event item, out string message)
        {
            if (string.IsNullOrEmpty(item.Name) || string.IsNullOrEmpty(item.Description))
            {
                message = "The name or description is be empty!";
                return default;
            }
            else
            {
                return _repository.TryCreate(item, out message);
            }
        }

        public bool TryUpdate(Guid id, Event item, out string message)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is null)
            {
                message = "Item not found";
                return false;
            }
            else
            {
                _item.Name = item.Name;
                _item.Description = item.Description;
                _item.EventDateTime = item.EventDateTime;
                _item.Location= item.Location;

                return _repository.TryUpdate(_item, out message);
            }
        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }
    }
}
