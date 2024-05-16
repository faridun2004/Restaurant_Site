using Restaurant_Site.Models;

namespace Restaurant_Site.server.Models
{
    public class ShoppingCart
    {
        public List<ShopingCartItem> Items { get; set; }
        public ShoppingCart()
        {
            Items = new List<ShopingCartItem>();
        }
        public void AddItem(Guid menuId, double quantity)
        {
            Items.Add(new ShopingCartItem { MenuId = menuId, Quantity = quantity });
        }
    }
}
