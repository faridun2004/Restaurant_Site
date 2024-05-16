using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.IServices.IFinanceServices;
using Restaurant_Site.Models.finances;

namespace Restaurant_Site.Controllers.FinanceControllers
{

    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("Expenses")]
    public class ExpensesController : ControllerBase
    {
       
    }
}
