using Restaurant_Site.Models;
using Restaurant_Site.Models.finances;

namespace Restaurant_Site.IServices.IFinanceServices
{
    public interface ISalaryService : IBaseService<Salary>
    {
        IEnumerable<Salary> GetSalariesForEmployee(Guid employeeId);
    }
}
