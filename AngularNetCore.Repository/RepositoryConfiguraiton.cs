using AngularNetCore.DataAccess.Models;
using AngularNetCore.Dto;
using AngularNetCore.Repository.Implementation;
using AngularNetCore.Repository.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AngularNetCore.Repository
{
    public static class RepositoryConfiguraiton
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AngularnetcoreContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("AngularNetCore")));
            services.AddScoped(typeof(IHeroesRepository), typeof(HeroesRepository));
        }

        public static void ConfigureAutomapper(Profile automapperProfile)
        {
            automapperProfile.CreateMap<Hero, HeroDto>();
        }
    }
}
