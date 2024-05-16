using MediatR;
using Restaurant_Site.Models;

namespace Restaurant_Site.CQRS.Commands
{
    public class CreateProductCommand : IRequest<(Product, string)>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid HolderId { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
    }
   
}
