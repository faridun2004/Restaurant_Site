using Restaurant_Site.server.Models.finances;
using Restaurant_Site.server.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;

namespace Restaurant_Site.server.Models
{
    public class Product 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public ProductStatus Status { get; set; }
        public ProductType DishType { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public int ProductCategoryId { get; set; } // Foreign Key
        public ProductCategory ProductCategory { get; set; }
    }
}