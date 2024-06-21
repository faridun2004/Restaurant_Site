using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models.finances;

namespace Restaurant_Site.server.IServices.IFinanceServices
{
    public interface ICashRegisterService: IBaseService<CashRegister>
    {
        decimal GetTotalCashAmount();

    }
}
