namespace Restaurant_Site.server.Models
{
    public class UpdateQuantityRequest
    {
        public int ProductId { get; set; }
        public int NewQuantity { get; set; }
    }
}
