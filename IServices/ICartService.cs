using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.IServices
{
    public interface ICartService
    {
        Cart GetCart();
        void AddToCart(CartItem item);
        void RemoveFromCart(int productId);
        void ClearCart();
        void UpdateQuantity(int productId, int newQuantity);
    }
}
