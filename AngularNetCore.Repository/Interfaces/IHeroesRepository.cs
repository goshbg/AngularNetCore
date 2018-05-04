using System.Collections.Generic;
using AngularNetCore.Dto;

namespace AngularNetCore.Repository.Interfaces
{
    public interface IHeroesRepository
    {
        HeroDto GetHeroById(int id);
        IList<HeroDto> GetHeroes(string searchString, int startIndex, int limit);
        int GetHeroesCount(string searchString);
    }
}
