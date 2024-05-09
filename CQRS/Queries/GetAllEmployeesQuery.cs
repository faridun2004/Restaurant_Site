using MediatR;
using Restaurant_Site.Models;

namespace Restaurant_Site.server.CQRS.Queries
{
    public class GetAllEmployeesQuery : IRequest<List<Employee>>
    {
    }
}
