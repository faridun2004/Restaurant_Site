using System.Text.Json.Serialization;

namespace Restaurant_Site.server.Models
{
    public class Event: BaseEntity
    {
        public string? Name { get; set; }
       
        public string? Location { get; set; }
        public string? Description { get; set; }
        [JsonIgnore]
        public DateTime EventDateTime { get; set; }
    }
}
