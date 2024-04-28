using AutoMapper;
using MediatR;
using Restaurant_Site.CQRS.Commands;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;

namespace Restaurant_Site.CQRS.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, string>
    {
        private IProductService _service;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<string> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            var result = _service.Update(request.ProductId, product);

            return Task.FromResult(result);
        }
    
    }
}
