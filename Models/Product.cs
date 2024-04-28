using System.Runtime.InteropServices.Marshalling;

namespace Restaurant_Site.Models
{
    public class Product: BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Guid HolderId { get; set; }
        public decimal Price { get; set; }
        public string? Photo {  get; set; }
        public ProductStatus Status { get; set; }
        public ProductType DishType { get; set; }

        
    }
}