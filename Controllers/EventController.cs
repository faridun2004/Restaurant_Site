using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.Controllers
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
