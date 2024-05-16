
using Restaurant_Site.Models.finances;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.Models
{
    public class Order: BaseEntity
    {
        public decimal TotalPrice => OrderDetails.Sum(d => d.TotalPrice);
        public List<OrderDetail>? OrderDetails { get; set; }
        public Sale? Sale { get; internal set; }
    }
}
