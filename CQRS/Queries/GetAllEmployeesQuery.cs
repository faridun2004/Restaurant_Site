using MediatR;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.CQRS.Queries
{
    public class GetAllEmployeesQuery : IRequest<List<Employee>>
    {
    }
}
