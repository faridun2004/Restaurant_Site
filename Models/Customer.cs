using System.Globalization;

namespace Restaurant_Site.Models
{
    public class Customer: Person
    {
        public CustomerStatus customerStatus {  get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}





