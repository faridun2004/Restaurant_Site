using System.Runtime.InteropServices.Marshalling;

namespace Restaurant_Site.Models
{
    public class Product: BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? Photo {  get; set; }
        public ProductStatus Status { get; set; }
        public ProductType DishType { get; set; }
        public ICollection<Menu> Menus { get; set; } = new List<Menu>();
        public Guid HolderId { get; set; }
    }
}