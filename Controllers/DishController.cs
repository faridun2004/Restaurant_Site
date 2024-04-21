using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;
using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.Extensions.Logging;
using Restaurant_Site.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Restaurant_Site.Extensions;
using Restaurant_Site.Infrastructure;
using Restaurant_Site.Contracts;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DishController : BaseController<Dish>  /* ControllerBase*/
    {
        public DishController(ILogger<DishController> logger, IDishService service) : base(logger, service)
        { }


    }
}
