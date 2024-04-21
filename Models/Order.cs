namespace Restaurant_Site.Models
{
    public class Order: BaseEntity
    {
        public List<Dish>? Dishes { get; set; }
        public Customer? Customer { get; set; }
        public Table? Table { get; set; }
        public OrderStatus? Status { get; set; }
    }

}
