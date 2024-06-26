using Restaurant_Site.server.Models.finances;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.server.Models
{
    public class Order: BaseEntity
    {
        private decimal _totalPrice;
        public decimal TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
        public string? Address { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
        public Sale? Sale { get;  set; }
        public Guid SaleId { get;  set; }
    }
}
