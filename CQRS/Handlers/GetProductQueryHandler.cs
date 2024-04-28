using MediatR;
using Restaurant_Site.CQRS.Queries;
using Restaurant_Site.Infrastructure;
using Restaurant_Site.Models;
namespace Restaurant_Site.Handlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly RestaurantContext _dbContext;

        public GetProductQueryHandler(RestaurantContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _dbContext.Products.FindAsync(request.Id);
            return product;
        }
    }
}
