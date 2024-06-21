using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.Controllers;
using Restaurant_Site.server.IServices.IFinanceServices;
using Restaurant_Site.server.Models.finances;

namespace Restaurant_Site.server.Controllers.FinanceControllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : BaseController<Salary>
    {
        public SalaryController(ILogger<SalaryController> logger, ISalaryService salaryService)
            : base(logger, salaryService)
        {}

    }
}
