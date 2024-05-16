using Restaurant_Site.server.Models;
using System.Globalization;
using System.Text.Json.Serialization;

namespace Restaurant_Site.Models
{
    public class Customer: Person
    {
        public CustomerStatus customerStatus {  get; set; }
        [JsonIgnore]
        public ICollection<OrderDetail> Orders { get; set; } = new List<OrderDetail>();
    }
}





