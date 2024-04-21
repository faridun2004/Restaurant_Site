using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("Event")]
    public class EventController : BaseController<Event>
    {
        public EventController(ILogger<EventController> logger, IEventService service) :
        base(logger, service)
        { }
    }
}
