using AutoMapper;
using Restaurant_Site.server.CQRS.Commands;
using Restaurant_Site.server.Models;

namespace Restaurant_Site.Mappings
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<CreateEmployeeCommand, Employee>();
            CreateMap<UpdateEmployeeCommand, Employee>();
        }
    }
}
