namespace Restaurant_Site.Models
{
    public class Menu: BaseEntity
    {
        public List<Product>? Products { get; set; }
    }
}
