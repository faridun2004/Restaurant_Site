using AutoMapper;
using MediatR;
using Restaurant_Site.server.CQRS.Commands;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.CQRS.Handlers
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand,(bool, string)>
    {
        private IEmployeeService _service;
        private readonly IMapper _mapper;

        public UpdateEmployeeCommandHandler(IEmployeeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<(bool,string)> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _mapper.Map<Employee>(request);
            var result = _service.TryUpdate(request.EmployeeId, employee, out string message); ;

            return Task.FromResult((result,message));
        }
    
    }
}
