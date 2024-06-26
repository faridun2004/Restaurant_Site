using MediatR;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.CQRS.Queries
{
    public class GetEmployeeByIdQuery : IRequest<Employee>
    {
        public Guid Id { get; set; }
    }
}
