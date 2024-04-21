using Restaurant_Site.Models;

namespace Restaurant_Site.Contracts
{
    public record ResponseDishDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Photo { get; set; }
        public DishType DishType { get; set; }
        public DishStatus DishStatus { get; set; }
        public Guid IssuerId { get; set; }


    }
}
