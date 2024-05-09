using MediatR;
using Restaurant_Site.Models;

namespace Restaurant_Site.CQRS.Queries
{
    public class GetEmployeeByIdQuery : IRequest<Employee>
    {
        public Guid Id { get; set; }
    }
}
