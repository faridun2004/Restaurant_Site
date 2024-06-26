using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.Controllers;
using Restaurant_Site.server.Models.finances;
using Restaurant_Site.server.IServices.IFinanceServices;

namespace Restaurant_Site.server.Controllers.FinanceControllers
{
    [ApiController]
    [Route("FinancialTransaction")]
    public class FinancialTransactionController:BaseController<FinancialTransaction>
    {
       public FinancialTransactionController(ILogger<FinancialTransactionController> logger, IFinancialTransactionService service):
              base(logger, service)
       {}
    }
}
