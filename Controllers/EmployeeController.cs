using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;
using Restaurant_Site.Services;
using System.Net;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("Employee")]
    public class EmployeeController : BaseController<Employee>
    {
        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService service): base(logger, service) 
        { }
    }
}
