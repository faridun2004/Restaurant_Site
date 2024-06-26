using AutoMapper;
using MediatR;
using Restaurant_Site.server.CQRS.Commands;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.CQRS.Handlers
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, (Employee,string)>
    {
        private IEmployeeService _service;
        private readonly IMapper _mapper;

        public CreateEmployeeCommandHandler(IEmployeeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<(Employee, string)> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _mapper.Map<Employee>(request);
            var createdItem = _service.TryCreate(employee, out string message);
            return Task.FromResult((createdItem, message));
        }
    }
}
