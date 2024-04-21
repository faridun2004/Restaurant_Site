using Restaurant_Site.Models.Enums;

namespace Restaurant_Site.Models
{
    public class Employee: Person
    {
        public EmployeeRole Responsibility { get; set; }
    }
}
