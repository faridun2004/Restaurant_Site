using Restaurant_Site.IServices;

namespace Restaurant_Site.Services
{
    public class ShoppingCartService: IShoppingCartService
    {
        private readonly IDishService _dishService;
        private readonly Dictionary<Guid, double> _cartItems = new Dictionary<Guid, double>();

        public ShoppingCartService(IDishService dishService)
        {
            _dishService = dishService;
        }

        public void AddToCart(Guid dishId, double quantity)
        {
            // Проверяем существование блюда с заданным ID
            var dish = _dishService.GetById(dishId);
            if (dish == null)
            {
                throw new ArgumentException("Dish not found.");
            }

            // Добавляем блюдо в корзину или обновляем количество, если блюдо уже есть в корзине
            if (_cartItems.ContainsKey(dishId))
            {
                _cartItems[dishId] += quantity;
            }
            else
            {
                _cartItems.Add(dishId, quantity);
            }
        }
        public void RemoveFromCart(Guid dishId)
        {
            if (_cartItems.ContainsKey(dishId))
            {
                _cartItems.Remove(dishId);
            }
            else
            {
                throw new ArgumentException("Item not found in cart.");
            }
        }
        public void UpdateQuantity(Guid dishId, double quantity)
        {
            if (_cartItems.ContainsKey(dishId))
            {
                _cartItems[dishId] = quantity;
            }
        }
    }
}
