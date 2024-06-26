using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;
using System.Net;

namespace Restaurant_Site.server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : BaseController<Payment>
    {
        public PaymentController(ILogger<PaymentController> logger, IPaymentService paymentService)
            : base(logger, paymentService) { }
    }
}
