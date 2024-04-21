namespace Restaurant_Site.Models
{
    public class Event: BaseEntity
    {
        public string? Name { get; set; }
        public DateTime EventDateTime { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
    }
}
