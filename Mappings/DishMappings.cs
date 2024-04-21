using AutoMapper;
using Restaurant_Site.Contracts;
using Restaurant_Site.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Restaurant_Site.Mappings
{
    public class DishMappings: Profile
    {
        public DishMappings()
        {
            CreateMap<DishDto, Dish>();
        }
    }
}
