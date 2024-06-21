using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.Models;
using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.Extensions.Logging;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Services;
using MediatR;
using Restaurant_Site.server.Models;


namespace Restaurant_Site.server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderDetailController : BaseController<OrderDetail>
    {
        public OrderDetailController(ILogger<OrderDetailController> logger, IOrderDetailService service) :
        base(logger, service)
        { }

        //: BaseController<Order>
        //{
        //    private readonly IMediator _mediator;
        //    private readonly ILogger<OrderController> _logger;
        //    private readonly IOrderService _orderService;
        //    private readonly IEmployeeService _employeeService;

        //    public OrderController(ILogger<OrderController> logger,
        //        IOrderService orderService, IEmployeeService employeeService, IMediator mediator) : 
        //        base(logger, orderService)
        //    {
        //        _mediator = mediator;
        //        _logger = logger;
        //        _orderService = orderService;
        //        _employeeService = employeeService;
        //    }
        //    [HttpPost("CreateOrder")]
        //    public async Task<ActionResult<bool>> CreateOrder(CreateOrderCommand command)
        //    {
        //        var result = await _mediator.Send(command);
        //        return Ok(result);
        //    }
        //    [HttpPost("Place order")]
        //    public async Task<IActionResult> PlaceOrder(Order order)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            // Проверка, был ли заказ успешно обработан поваром
        //            if (await _employeeService.ProcessOrderAsync(order))
        //            {
        //                // Заказ успешно обработан поваром
        //                // Далее можно добавить заказ в базу данных или выполнить другие действия
        //                // Например:
        //                _orderService.Create(order);
        //                return Ok("Order placed successfully.");
        //            }
        //            else
        //            {
        //                // Не удалось обработать заказ поваром (нет доступных поваров)
        //                return BadRequest("No available chefs to process the order.");
        //            }
        //        }
        //        else
        //        {
        //            // Некорректные данные заказа
        //            return BadRequest(ModelState);
        //        }
        //    }

    }
}
