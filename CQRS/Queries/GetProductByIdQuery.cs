using MediatR;
using Restaurant_Site.Models;

namespace Restaurant_Site.CQRS.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public Guid Id { get; set; }

    }
}
