using Restaurant_Site.IServices;
using Restaurant_Site.Models;

namespace Restaurant_Site.Services
{
    public class ShoppingCartService: IShoppingCartService
    {
        private readonly IProductService _dishService;
        private readonly Dictionary<Guid, double> _cartItems = new Dictionary<Guid, double>();

        public ShoppingCartService(IProductService dishService)
        {
            _dishService = dishService;
        }
        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var (dishId, quantity) in _cartItems)
            {
                var dish = _dishService.GetById(dishId);
                if (dish != null)
                {
                    totalPrice += (decimal)dish.Price * (decimal)quantity;
                }
            }

            return totalPrice;
        }
        public IEnumerable<ShopingCartItem> GetAll()
        {
            List<ShopingCartItem> allItems = new List<ShopingCartItem>();
            foreach (var item in _cartItems)
            {
                allItems.Add(new ShopingCartItem { MenuId = item.Key, Quantity = item.Value });
            }
            return allItems;
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
