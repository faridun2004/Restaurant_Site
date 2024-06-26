using AutoMapper;
using Restaurant_Site.server.Contracts;
using Restaurant_Site.server.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Restaurant_Site.server.Mappings
{
    public class DishDTOMappings: Profile
    {
        public DishDTOMappings()
        {
            CreateMap<DishDto, Product>();
        }
    }
}
