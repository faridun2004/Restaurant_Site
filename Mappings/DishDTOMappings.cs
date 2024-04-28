using AutoMapper;
using Restaurant_Site.Contracts;
using Restaurant_Site.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Restaurant_Site.Mappings
{
    public class DishDTOMappings: Profile
    {
        public DishDTOMappings()
        {
            CreateMap<DishDto, Product>();
        }
    }
}
