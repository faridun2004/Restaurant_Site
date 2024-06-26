using MediatR;
using Restaurant_Site.Infrastructure;
using Restaurant_Site.server.CQRS.Queries;
using Restaurant_Site.server.Infrastructure;
using Restaurant_Site.server.Models;
namespace Restaurant_Site.server.Handlers
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly RestaurantContext _dbContext;

        public GetEmployeeQueryHandler(RestaurantContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employee = await _dbContext.Employees.FindAsync(request.Id);
            return employee;
        }
    }
}
