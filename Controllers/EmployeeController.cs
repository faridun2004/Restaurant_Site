using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.Services;
using System.Net;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("Employee")]
    
    public class EmployeeController : BaseController<Employee>
    {
        protected readonly IEmployeeService _employeeService;
        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService service): base(logger, service) 
        {}
        [HttpPost("PlaceOrder")]
        public virtual IActionResult PlaceOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                // Проверяем, был ли заказ успешно обработан поваром
                if (_employeeService.ProcessOrderAsync(order).Result) // Вызываем метод обработки заказа из сервиса сотрудников
                {
                    // Заказ успешно обработан поваром
                    // Далее можно добавить заказ в базу данных или выполнить другие действия
                    // Например:
                    // _orderService.Create(order);
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
