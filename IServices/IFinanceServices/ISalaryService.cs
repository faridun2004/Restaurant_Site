using Restaurant_Site.server.Models;
using Restaurant_Site.server.Models.finances;

namespace Restaurant_Site.server.IServices.IFinanceServices
{
    public interface ISalaryService : IBaseService<Salary>
    {
        IEnumerable<Salary> GetSalariesForEmployee(Guid employeeId);
    }
}
