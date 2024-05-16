using System.Text.Json.Serialization;

namespace Restaurant_Site.Models
{
    public class ShopingCartItem
    {
        public Guid MenuId { get; set; }
        public double Quantity { get; set; }
        //[JsonIgnore]
        //public Menu? Menu { get; set; }

    }
}