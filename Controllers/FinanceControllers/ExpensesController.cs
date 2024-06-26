using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.IServices.IFinanceServices;
using Restaurant_Site.server.Models.finances;
using Restaurant_Site.Services.FinanceServices;

namespace Restaurant_Site.server.Controllers.FinanceControllers
{

    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("Expenses")]
    public class ExpensesController : BaseController<Expense>
    {
        private readonly IExpenseService _expenseService;
        public ExpensesController(ILogger<ExpensesController> logger, IExpenseService service) : base(logger, service) 
        {
            _expenseService = service;
        }
        [HttpGet("period")]
        public ActionResult<IEnumerable<Expense>> GetExpensesInPeriod(DateTime startDate, DateTime endDate)
        {
            var expenses = _expenseService.GetExpensesInPeriod(startDate, endDate);
            return Ok(expenses);
        }

        [HttpGet("total")]
        public ActionResult<decimal> GetTotalExpensesInPeriod(DateTime startDate, DateTime endDate)
        {
            var totalExpenses = _expenseService.GetTotalExpensesInPeriod(startDate, endDate);
            return Ok(totalExpenses);
        }
       
    }
}
