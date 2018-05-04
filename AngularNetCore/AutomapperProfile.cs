using AngularNetCore.Dto;
using AngularNetCore.Models;
using AngularNetCore.Repository;
using AutoMapper;

namespace AngularNetCore
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<HeroDto, HeroModel>();
            RepositoryConfiguraiton.ConfigureAutomapper(this);
        }
    }
}