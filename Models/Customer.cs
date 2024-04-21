using System.Globalization;

namespace Restaurant_Site.Models
{
    public class Customer: Person
    {
        public CustomerStatus customerStatus {  get; set; }
        public CultureTypes customerType { get; set; }
    }
}





