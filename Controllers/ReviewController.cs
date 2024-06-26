using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.Controllers
{
    [ApiController]
    [Route("Review")]
    public class ReviewController : BaseController<Review>
    {
        public ReviewController(ILogger<ReviewController> logger, IReviewService service) : base(logger, service)
        { }
    }
}
