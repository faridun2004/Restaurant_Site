
namespace Restaurant_Site.Models
{
    public class Order: BaseEntity
    {
        public List<Product>? products { get; set; }
        public Customer? customer { get; set; }
        public Table? table { get; set; }
        public OrderStatus? status { get; set; }
        public DateTime CretionalDate { get; internal set; }= DateTime.Now;
        public DateTime EditDate { get; internal set; }
        public Guid CustomerId { get; set; }
        public Guid TableId { get; set; }     
    }
}
