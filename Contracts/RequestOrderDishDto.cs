using Restaurant_Site.Models;


namespace Restaurant_Site.Contracts
{
    public record RequestOrderDishDto
    {
        public string Name { get; set; }
        public DishType Type { get; set; }
        public DishStatus Status { get; set; }
        public decimal Price {  get; set; }
        public Guid HolderId { get; set; }
    }
}
