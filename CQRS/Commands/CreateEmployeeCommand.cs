﻿using MediatR;
using Restaurant_Site.server.Models;
using Restaurant_Site.server.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Restaurant_Site.server.CQRS.Commands
{
    public class CreateEmployeeCommand : IRequest<(Employee, string)>
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Address { get; set; }

        public string? ContactInfo { get; set; }

        public string? FullName => $"{FirstName} {LastName}";
        public string? Username { get; set; }

        public string? Password { get; set; }
        [Required]
        public string? RefreshToken { get; set; }
        public EmployeeRole Responsibility { get; set; }
        public string Role { get; set; }
        [JsonIgnore]
        public bool IsBlocked { get; }
    }
}
