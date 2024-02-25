namespace Restaurant_Site.Models
{
    public class Menu: BaseEntity
    {
        public List<Dish>? Dishes { get; set; }
    }
}
