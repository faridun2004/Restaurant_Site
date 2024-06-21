using FluentValidation;
using Restaurant_Site.server.Contracts;
using Restaurant_Site.server.Models.Enums;

namespace Restaurant_Site.server.Validations
{
    public class DishDtoValidation: AbstractValidator<RequestOrderDishDto>
    {
        public DishDtoValidation()
        {
            RuleFor(x => x.Type).Must(t => t > ProductType.Tajikan).WithMessage("Tajikan food can be ordered only in the Restaurant");
            RuleFor(x => x.HolderId).Must(t => t != Guid.Empty).WithMessage("HolderId must have value");
        }
    }
}
