using Restaurant_Site.Models.Enums;
using Restaurant_Site.Models.finances;
using Restaurant_Site.server.Models;
using System.Text.Json.Serialization;

namespace Restaurant_Site.Models
{
    public class Employee: Person
    {
        public EmployeeRole Responsibility { get; set; }
        public bool IsAvailable { get;  set; }
        [JsonIgnore]
        public ICollection<OrderDetail>? Orders { get; set; }
        public List<Salary>? Salaries { get;  set; }
        public List<Sale>? Sales { get; internal set; }
    }
}
