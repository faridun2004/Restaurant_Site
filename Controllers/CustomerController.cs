using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;
using System.Net;

namespace Restaurant_Site.server.Controllers
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
