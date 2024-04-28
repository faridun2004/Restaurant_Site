using FluentValidation;
using Restaurant_Site.Contracts;
using Restaurant_Site.Models;

namespace Restaurant_Site.Validations
{
    public class DishDtoValidation: AbstractValidator<RequestOrderDishDto>
    {
        public DishDtoValidation()
        {
            RuleFor(x => x.Type).Must(t => t > ProductType.Tajikan).WithMessage("Chinese food can be ordered only in the Restaurant");
            RuleFor(x => x.HolderId).Must(t => t != Guid.Empty).WithMessage("HolderId must have value");
        }
    }
}
