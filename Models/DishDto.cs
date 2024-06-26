using Restaurant_Site.server.Models.Enums;

namespace Restaurant_Site.server.Models
{
    public class DishDto: BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Photo { get; set; }
        public ProductType dishType { get; set; }
        public Guid HolderId { get; set; }
        public Guid IssuerId { get; set; }
        public ProductStatus dishStatus { get; set; } = ProductStatus.JustOrdered;
    }
}
