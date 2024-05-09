using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.Models;

namespace Restaurant_Site.CQRS.Commands
{
    public class DeleteEmployeeCommand : IRequest<string>
    {
        [FromQuery]
        public Guid EmployeeId { get; set; }
    }
}
