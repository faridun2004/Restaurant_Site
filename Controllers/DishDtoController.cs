using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Contracts;
using Restaurant_Site.Extensions;
using Restaurant_Site.Infrastructure;
using Restaurant_Site.Models;
using Restaurant_Site.Validations;

namespace Restaurant_Site.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DishDTOController : ControllerBase
    {
        private readonly ILogger<DishDTOController> _logger;
        private readonly RestaurantContext _context;
        private readonly IMapper _mapper;
        public DishDTOController(ILogger<DishDTOController> logger, RestaurantContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpGet("DishByHolderId")]
        public IEnumerable<ResponseDishDto> DishesByHolderId(RequestDishDtoByHolderId holderId)
        {
            var dishes = _context.Products.Where(c => c.HolderId == holderId.HorderId);
            return _mapper.Map<List<ResponseDishDto>>(dishes);
        }
        [HttpPost("Order")]
        [Authorize]
        public string OrderDish(RequestOrderDishDto requestOrder)
        {
            var validator = new DishDtoValidation();
            var result = validator.Validate(requestOrder);
            if (!result.IsValid)
            {
                var message = string.Join("; ", result.Errors);
                return message;
            }
            var employeeId = User.GetCurrectUserId();
            var dish = _mapper.Map<DishDto>(requestOrder);
            dish.IssuerId = employeeId;
            _context.Add(dish);
            _context.SaveChanges();

            return "Dish is ordered";
        }
        [HttpPost("AddDish")]
        [Authorize(Roles = "admin")] // Предположим, что только администратор может добавлять блюда
        public IActionResult AddDish(DishDto dishDTO)
        {
            var dish = _mapper.Map<Product>(dishDTO); // Преобразование DishDTO в модель Dish

            _context.Products.Add(dish);
            _context.SaveChanges();

            return Ok("Блюдо успешно добавлено");
        }
    }
}
