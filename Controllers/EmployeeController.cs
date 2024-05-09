using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.CQRS.Commands;
using Restaurant_Site.CQRS.Queries;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.server.CQRS.Queries;
using Restaurant_Site.Services;
using System.Net;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("Employee")]  
    public class EmployeeController : /*BaseController<Employee>*/ ControllerBase
    {
        protected readonly IEmployeeService _employeeService;
        //public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService service): base(logger, service) 
        //{}
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
                    //  _orderService.Create(order);
                    return Ok("Order placed successfully.");
                }
                else
                {
                    return BadRequest("No available chefs to process the order.");
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("AllEmployee")]
        public async Task<ActionResult<List<Employee>>> GetAllEmployees()
        {
            var query = new GetAllEmployeesQuery();
            var employees = await _mediator.Send(query);
            return Ok(employees);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployeeById(Guid id)
        {
            var query = new GetEmployeeByIdQuery() { Id = id };
            var product = await _mediator.Send(query);
            if (product == null)
                return NotFound();

            return Ok(product);
        }
        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(CreateEmployeeCommand command)
        {
            var product = await _mediator.Send(command);
            return Ok(product);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<string>> UpdateEmployee(Guid id, UpdateEmployeeCommand command)
        {
            command.EmployeeId = id;
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Deleteemployee(DeleteEmployeeCommand deleteEmployee)
        {
            var result = await _mediator.Send(deleteEmployee);
            return Ok(result);
        }
    }
}
