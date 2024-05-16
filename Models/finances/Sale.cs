namespace Restaurant_Site.Models.finances
{
    public class Sale: BaseEntity
    {
        public DateTime SaleDateTime { get; set; }
        public decimal TotalAmount { get; set; }
        public List<Product>? ProductsSold { get; set; }
        public Employee? Employee { get; set; }
        public Guid EmployeeId { get; set; }
        public Order? Order { get; set; }
    }
}
