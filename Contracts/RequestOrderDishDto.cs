using Restaurant_Site.Models;


namespace Restaurant_Site.Contracts
{
    public record RequestOrderDishDto
    {
        public string? Name { get; set; }
        public ProductType Type { get; set; }
        public ProductStatus Status { get; set; }
        public decimal Price {  get; set; }
        public Guid HolderId { get; set; }
    }
}
