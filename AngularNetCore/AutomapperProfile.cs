using AngularNetCore.DataAccess.Models;
using AngularNetCore.Models;
using AutoMapper;

namespace AngularNetCore
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Hero, HeroModel>();
        }
    }
}