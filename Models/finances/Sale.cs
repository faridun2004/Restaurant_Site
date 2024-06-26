namespace Restaurant_Site.server.Models.finances
{
    public class Sale: BaseEntity
    {
        public DateTime SaleDateTime { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<Product> ProductsSold { get; set; }
        public Employee? Employee { get; set; }
        public Guid EmployeeId { get; set; }
        public  List<Order>? Order { get; set; }
        public Guid? OrderId { get; set; }
        public Product Product { get; set; }
        public int  ProductId { get; internal set; }
        
    }
}
