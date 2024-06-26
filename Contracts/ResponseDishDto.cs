using Restaurant_Site.server.Models.Enums;

namespace Restaurant_Site.server.Contracts
{
    public record ResponseDishDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Photo { get; set; }
        public ProductType DishType { get; set; }
        public ProductStatus DishStatus { get; set; }
        public Guid IssuerId { get; set; }


    }
}
