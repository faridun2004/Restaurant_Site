using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;
using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.Extensions.Logging;
using Restaurant_Site.IServices;

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
