using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("Review")]
    public class ReviewController : BaseController<Review>
    {
        public ReviewController(ILogger<ReviewController> logger, IReviewService service) : base(logger, service)
        { }
    }
}
