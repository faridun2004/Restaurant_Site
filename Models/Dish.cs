using System.Runtime.InteropServices.Marshalling;

namespace Restaurant_Site.Models
{
    public class Dish: BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }
}
