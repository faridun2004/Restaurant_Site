using MediatR;
using System.Text.Json.Serialization;

namespace Restaurant_Site.CQRS.Commands
{
    public class UpdateProductCommand : IRequest<(bool, string)>
    {
        [JsonIgnore]
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
        /*public UpdateProductCommand(Guid productId, string name, string description, decimal price, string photo)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Price = price;
            Photo = photo;
        }*/
    }
}
