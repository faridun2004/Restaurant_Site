using Restaurant_Site.Models;

namespace Restaurant_Site.IServices
{
    public interface IShoppingCartService 
    {
        
        void AddToCart(Guid menuId, double quantity);
        void RemoveFromCart(Guid menuId); // Добавленный метод
        void UpdateQuantity(Guid menuId, double quantity);
        IEnumerable<ShopingCartItem> GetAll();
    }
}
