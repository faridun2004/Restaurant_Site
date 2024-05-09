namespace Restaurant_Site.Models
{
    public class ShopingCartItem
    {
        public Guid MenuId { get; set; }
        public double Quantity { get; set; }
        public decimal CalculateTotalPrice(Product dish)
        {
            return (decimal)dish.Price * (decimal)Quantity;
        }

    }
}