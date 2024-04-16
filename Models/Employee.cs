namespace Restaurant_Site.Models
{
    public class Employee: Person
    {
        public Role Responsibility { get; set; }
    }
    public enum Role
    {
        Waiter,
        Chef,
        Manager,
        Deliveryman

    }
}
