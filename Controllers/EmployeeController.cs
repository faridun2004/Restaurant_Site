using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.CQRS.Commands;
using Restaurant_Site.server.CQRS.Queries;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;
using Restaurant_Site.server.Controllers;
using Restaurant_Site.server.CQRS.Queries;
using Restaurant_Site.server.IServices;

namespace Restaurant_Site.server.Controllers
{
    [ApiController]
    [Route("Employee")]  
    public class EmployeeController : ControllerBase
    {
        protected readonly IEmployeeService _employeeService;
        [HttpPost("PlaceOrder")]
        public virtual IActionResult PlaceOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                if (_employeeService.ProcessOrderAsync(order).Result) 
                {
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
            var employee = await _mediator.Send(query);
            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(CreateEmployeeCommand command)
        {
           var (createdItem, message) = await _mediator.Send(command);
            if(createdItem is null)
                return BadRequest(message);

            return Ok(createdItem);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<string>> UpdateEmployee(Guid id, UpdateEmployeeCommand command)
        {
            command.EmployeeId = id;
            var (result, message) = await _mediator.Send(command);
            if (result)
                return Ok(message);

            return BadRequest(message);
        }

        [HttpDelete]
        public async Task<IActionResult> Deleteemployee(DeleteEmployeeCommand deleteEmployee)
        {
            var (result, message) = await _mediator.Send(deleteEmployee);
            if (result)
                return Ok(message);

            return BadRequest(message);
        }
    }
}
