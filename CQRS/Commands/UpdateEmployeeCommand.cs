using MediatR;
using Restaurant_Site.server.Models.Enums;
using System.Text.Json.Serialization;

namespace Restaurant_Site.server.CQRS.Commands
{
    public class UpdateEmployeeCommand : IRequest<(bool,string)>
    {
        [JsonIgnore]
        public Guid EmployeeId { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Address { get; set; }

        public string? ContactInfo { get; set; }
        public EmployeeRole Responsibility { get; set; }
        public string Role { get; set; }
       /* public UpdateEmployeeCommand(Guid employeeId, string firstName, string lastName, 
            string address, string contact)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            ContactInfo = contact;
        }*/
    }
}
