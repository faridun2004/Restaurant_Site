using AutoMapper;
using MediatR;
using Restaurant_Site.CQRS.Queries;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;

namespace Restaurant_Site.CQRS.Handlers
{
    public class GetAllProductQueryHandler: IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly IProductService _service;
        
        private readonly IMapper _mapper;

        public GetAllProductQueryHandler(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var clients = _service.GetAll().ToList();
            return await Task.FromResult(clients);
        }
    }
}

