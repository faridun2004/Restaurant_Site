using AutoMapper;
using MediatR;
using Restaurant_Site.CQRS.Commands;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;

namespace Restaurant_Site.CQRS.Handlers
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Employee>
    {
        private IEmployeeService _service;
        private readonly IMapper _mapper;

        public CreateEmployeeCommandHandler(IEmployeeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _mapper.Map<Employee>(request);
            _service.Create(employee);
            return Task.FromResult(employee);
        }
    }
}
