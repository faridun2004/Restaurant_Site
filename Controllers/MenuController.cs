using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using System.Net;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : BaseController<Menu> 
    {
        public MenuController(ILogger<MenuController> logger, IMenuService menuService) : base(logger, menuService)
        { }
    }

}
