using AutoMapper;
using MediatR;
using Restaurant_Site.CQRS.Commands;
using Restaurant_Site.IServices;

namespace Restaurant_Site.CQRS.Handlers
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, string>
    {
        private IEmployeeService _service;
        private readonly IMapper _mapper;

        public DeleteEmployeeCommandHandler(IEmployeeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<string> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var result = _service.Delete(request.EmployeeId);
            return Task.FromResult(result);
        }
    }
}
