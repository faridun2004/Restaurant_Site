using Restaurant_Site.Models;

namespace Restaurant_Site.server.Models
{
    public class OrderDetail : BaseEntity
    {
        public Product? Product { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Product.Price * Quantity;
        public Customer? Customer { get; set; }
        public Guid CustomerId { get; set; }
        public Table? Table { get; set; }
        public Guid TableId { get; set; }
        public Employee? Employee { get; set; }
        public Guid EmployeeId { get; set; }
        public Order? Order { get; set; }
        public Guid OrderId { get; set; }
        public OrderStatus? status { get; set; }
        public DateTime CretionalDate { get; internal set; } = DateTime.Now;
        public DateTime EditDate { get; internal set; }

    }
}
