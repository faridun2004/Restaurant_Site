using AutoMapper;
using MediatR;
using Restaurant_Site.CQRS.Commands;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;

namespace Restaurant_Site.CQRS.Handlers
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, string>
    {
        private IProductService _service;
        private readonly IMapper _mapper;

        public UpdateEmployeeCommandHandler(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<string> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _mapper.Map<Product>(request);
            var result = _service.Update(request.EmployeeId, employee);

            return Task.FromResult(result);
        }
    
    }
}
