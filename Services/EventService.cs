using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.Repository;

namespace Restaurant_Site.Services
{
    public class EventService: IEventService
    {
        private readonly ISQLRepository<Event> _repository;

        public EventService(ISQLRepository<Event> repository)
        {
            _repository = repository;
        }

        public IQueryable<Event> GetAll()
        {
            return _repository.GetAll();
        }

        public Event GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Create(Event item)
        {
            _repository.Create(item);
            return $"Created new event with this ID: {item.Id}";
        }

        public string Update(Guid id, Event item)
        {
            var existingEvent = _repository.GetById(id);
            if (existingEvent != null)
            {
                // Update existing event properties here
                _repository.Update(existingEvent);
                return "Event updated successfully.";
            }
            else
            {
                return "Event not found.";
            }
        }

        public string Delete(Guid id)
        {
            var result = _repository.Delete(id);
            if (result)
                return "Event deleted successfully.";
            else
                return "Event not found.";
        }
    }
}
