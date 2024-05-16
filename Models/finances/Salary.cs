namespace Restaurant_Site.Models.finances
{
   
    public class Salary: BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime SalaryDateTime { get; set; }
        public Employee? Employee { get; set; }
        public Guid EmployeeId { get; set; }
        
    }
}
