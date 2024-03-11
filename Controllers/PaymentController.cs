using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using System.Net;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : BaseController<Payment>
    {
        public PaymentController(ILogger<PaymentController> logger, IPaymentService paymentService)
            : base(logger, paymentService) { }
    }
}
