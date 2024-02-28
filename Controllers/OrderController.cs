using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;
using Restaurant_Site.Services;
using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.Extensions.Logging;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : BaseController<Order>
    {
        public OrderController(ILogger<OrderController> logger, IOrderService orderService): base(logger, orderService)
        {
        }
    }
}
