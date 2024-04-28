using MediatR;
using Restaurant_Site.Models;

namespace Restaurant_Site.CQRS.Queries
{
    public class GetAllProductsQuery: IRequest<List<Product>>
    {
    }
}
