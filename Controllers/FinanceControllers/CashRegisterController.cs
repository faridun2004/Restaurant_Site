using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Restaurant_Site.Controllers;
using Restaurant_Site.Models.finances;
using Restaurant_Site.server.IServices.IFinanceServices;

namespace Restaurant_Site.server.Controllers.FinanceControllers
{
    [ApiController]
    [Route("CashRegister")]
    [Authorize(Roles ="manager")]
    public class CashRegisterController:BaseController<CashRegister>
    {
        public CashRegisterController(ILogger<CashRegisterController> logger, ICashRegisterService service):
            base(logger, service)
        {}
    }
}
