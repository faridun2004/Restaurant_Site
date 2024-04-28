namespace Restaurant_Site.Models
{
    public class Delivery:BaseEntity
    {
        public DateTime DeliveryDateTime { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public decimal DeliveryFee { get; set; }
        public Guid OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
