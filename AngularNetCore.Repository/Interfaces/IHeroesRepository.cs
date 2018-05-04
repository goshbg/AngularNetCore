using System.Collections.Generic;
using AngularNetCore.Dto;

namespace AngularNetCore.Repository.Interfaces
{
    public interface IHeroesRepository
    {
        HeroDto GetHeroById(int id);
        IList<HeroDto> GetHeroes(string searchString, int currentPage, int pageSize);
        int GetHeroesCount(string searchString);
    }
}
