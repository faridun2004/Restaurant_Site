using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Controllers;
using Restaurant_Site.IServices.IFinanceServices;
using Restaurant_Site.Models.finances;

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
        //[HttpGet("SalariesForEmployee/{employeeId}")]
        //[AllowAnonymous]
        //public IActionResult GetSalariesForEmployee(Guid employeeId)
        //{
        //    var salaries = _baseService.GetSalariesForEmployee(employeeId);
        //    if (salaries == null || !salaries.Any())
        //    {
        //        return NotFound();
        //    }
        //    return Ok(salaries);
        //}
    }
}
