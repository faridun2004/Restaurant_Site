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
    public class DishController : BaseController<Dish>
    {
        public DishController(ILogger<DishController> logger, IDishService service) : base(logger, service)
        {
        }
    } 
}
