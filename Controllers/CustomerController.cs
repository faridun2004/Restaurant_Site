using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;
using Restaurant_Site.Services;
using System.Net;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("Customer")]
    public class CustomerController : BaseController<Customer>
    {
        public CustomerController(ILogger<CustomerController> logger, ICustomerService service) :
        base(logger, service)
        {}
    }          
}
