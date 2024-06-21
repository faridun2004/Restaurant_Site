using AutoMapper;
using MediatR;
using Restaurant_Site.server.CQRS.Commands;
using Restaurant_Site.server.IServices;

namespace Restaurant_Site.server.CQRS.Handlers
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, (bool,string)>
    {
        private IEmployeeService _service;
        private readonly IMapper _mapper;

        public DeleteEmployeeCommandHandler(IEmployeeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<(bool, string)> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var result = _service.TryDelete(request.EmployeeId, out string message);
            ;
            return Task.FromResult((result, message));
        }
    }
}
