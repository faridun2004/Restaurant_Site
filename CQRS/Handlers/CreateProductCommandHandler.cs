using AutoMapper;
using MediatR;
using Restaurant_Site.CQRS.Commands;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.Repository;

namespace Restaurant_Site.CQRS.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private IProductService _service;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Product>(request);
            _service.Create(user);
            return Task.FromResult(user);
        }
    }
}
