using AutoMapper;
using MediatR;
using Restaurant_Site.CQRS.Commands;
using Restaurant_Site.IServices;

namespace Restaurant_Site.CQRS.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, string>
    {
        private IProductService _service;
        private readonly IMapper _mapper;

        public DeleteProductCommandHandler(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<string> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var result = _service.Delete(request.ProductId);
            return Task.FromResult(result);
        }
    }
}
