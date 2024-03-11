namespace Restaurant_Site.Models
{
    public class Employee: Person
    {
        public Role Role { get; set; }
    }
    public enum Role
    {
        Waiter,
        Chef,
        Manager
    }
}
