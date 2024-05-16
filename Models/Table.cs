using Restaurant_Site.server.Models;
using System.Text.Json.Serialization;

namespace Restaurant_Site.Models
{
    public class Table: BaseEntity
    {
        public string? Capacity { get; set; }
        [JsonIgnore]
        public ICollection<OrderDetail> Orders { get; set; } = new List<OrderDetail>();
    }
}
