using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.Controllers;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.IServices.IFinanceServices;
using Restaurant_Site.server.Models.finances;
using Restaurant_Site.server.IServices.IFinanceServices;

namespace Restaurant_Site.server.Controllers.FinanceControllers
{
    [ApiController]
    [Route("ExpenseCategory")]
    public class ExpenseCategoryController: BaseController<ExpenseCategory>
    {
        public ExpenseCategoryController(ILogger<ExpenseCategoryController> logger, IExpenseCategoryService service)
           : base(logger, service)
        {}
    }
}
