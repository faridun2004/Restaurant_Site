using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;

namespace Restaurant_Site.CQRS.Commands
{
    public class DeleteProductCommand : IRequest<string>
    {
        [FromQuery]
        public Guid ProductId { get; set; }
    }
}
