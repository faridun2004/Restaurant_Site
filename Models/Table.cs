namespace Restaurant_Site.Models
{
    public class Table: BaseEntity
    {
        public string? Capacity { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
