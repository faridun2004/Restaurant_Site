using Restaurant_Site.IServices;
using Restaurant_Site.Models.finances;

namespace Restaurant_Site.server.IServices.IFinanceServices
{
    public interface ICashRegisterService: IBaseService<CashRegister>
    {
        decimal GetTotalCashAmount();

    }
}
