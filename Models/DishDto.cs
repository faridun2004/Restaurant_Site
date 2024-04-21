using Microsoft.VisualBasic;

namespace Restaurant_Site.Models
{
    public class DishDto: BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Photo { get; set; }
        public DishType dishType { get; set; }

        public Guid HolderId { get; set; }

        public Guid IssuerId { get; set; }

        public DishStatus dishStatus { get; set; } = DishStatus.JustOrdered;
    }
}
