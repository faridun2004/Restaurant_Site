using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Restaurant_Site.server.Models
{
    public abstract class Person: BaseEntity
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
        public string? Role { get; set; }
        [JsonIgnore]
        public bool IsBlocked { get; }
    }
}