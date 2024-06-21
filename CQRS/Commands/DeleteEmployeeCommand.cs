using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.CQRS.Commands
{
    public class DeleteEmployeeCommand : IRequest<(bool,string)>
    {
        [FromQuery]
        public Guid EmployeeId { get; set; }
    }
}
