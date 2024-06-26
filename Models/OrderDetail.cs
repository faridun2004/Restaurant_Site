using Restaurant_Site.server.Models.Enums;
using Restaurant_Site.server.Models.finances;

namespace Restaurant_Site.server.Models
{
    public class OrderDetail : BaseEntity
    {
        public Product? Product { get; set; }
        public int ProductId { get; set; }
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
        public DateTime CreationDate { get; internal set; }
        public DateTime EditDate { get; internal set; }

    }
}
