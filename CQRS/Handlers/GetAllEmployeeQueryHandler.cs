using AutoMapper;
using MediatR;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.server.CQRS.Queries;

namespace Restaurant_Site.CQRS.Handlers
{
    public class GetAllEmployeeQueryHandler: IRequestHandler<GetAllEmployeesQuery, List<Employee>>
    {
        private readonly IEmployeeService _service;
        
        private readonly IMapper _mapper;

        public GetAllEmployeeQueryHandler(IEmployeeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<List<Employee>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employee = _service.GetAll().ToList();
            return await Task.FromResult(employee);
        }
    }
}
