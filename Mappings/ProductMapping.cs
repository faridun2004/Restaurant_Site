using AutoMapper;
using Restaurant_Site.CQRS.Commands;
using Restaurant_Site.Models;

namespace Restaurant_Site.Mappings
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<CreateProductCommand, Product>();
            CreateMap<UpdateProductCommand, Product>();
        }
    }
}
