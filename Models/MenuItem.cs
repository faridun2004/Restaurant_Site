using System.Text.Json.Serialization;

namespace Restaurant_Site.Models
{
    public class Menu: BaseEntity
    {
        public Guid ProductId { get; internal set; }
        [JsonIgnore]
        public List<Product>? Products { get; set; }
    }
}
