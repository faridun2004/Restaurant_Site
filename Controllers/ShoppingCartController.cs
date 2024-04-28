using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using System;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var allItems = _shoppingCartService.GetAll();
                return Ok(allItems);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPost("AddToCart")]
        public IActionResult AddToCart([FromBody] ShopingCartItem item)
        {
            try
            {
                _shoppingCartService.AddToCart(item.MenuId, item.Quantity);
                return Ok("Item added to cart successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPost("RemoveFromCart")]
        public IActionResult RemoveFromCart([FromBody] ShopingCartItem item)
        {
            try
            {
                _shoppingCartService.RemoveFromCart(item.MenuId);
                return Ok("Item removed from cart successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPost("UpdateQuantity")]
        public IActionResult UpdateQuantity([FromBody] ShopingCartItem item)
        {
            try
            {
                _shoppingCartService.UpdateQuantity(item.MenuId, item.Quantity);
                return Ok("Quantity updated successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
