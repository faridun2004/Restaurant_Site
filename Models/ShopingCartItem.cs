namespace Restaurant_Site.Models
{
    public class ShopingCartItem
    {
        public Guid MenuId { get; set; }
        public double Quantity { get; set; }
        public decimal CalculateTotalPrice(Product dish)
        {
            // Получаем цену блюда из параметра dish и умножаем на количество
            return (decimal)dish.Price * (decimal)Quantity;
        }

    }
}