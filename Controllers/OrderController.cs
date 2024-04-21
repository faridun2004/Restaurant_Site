using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;
using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.Extensions.Logging;
using Restaurant_Site.IServices;
using Restaurant_Site.Services;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : BaseController<Order>
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderService _orderService;
        private readonly IEmployeeService _employeeService;

        public OrderController(ILogger<OrderController> logger, IOrderService orderService, IEmployeeService employeeService): base(logger, orderService)
        {
            _logger = logger;
            _orderService = orderService;
            _employeeService = employeeService;
        }
        [HttpPost("Place order")]
        public async Task<IActionResult> PlaceOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                // Проверка, был ли заказ успешно обработан поваром
                if (await _employeeService.ProcessOrderAsync(order))
                {
                    // Заказ успешно обработан поваром
                    // Далее можно добавить заказ в базу данных или выполнить другие действия
                    // Например:
                    _orderService.Create(order);
                    return Ok("Order placed successfully.");
                }
                else
                {
                    // Не удалось обработать заказ поваром (нет доступных поваров)
                    return BadRequest("No available chefs to process the order.");
                }
            }
            else
            {
                // Некорректные данные заказа
                return BadRequest(ModelState);
            }
        }

    }
}
