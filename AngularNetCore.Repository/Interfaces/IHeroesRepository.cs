using System.Collections.Generic;
using AngularNetCore.DataAccess.Models;

namespace AngularNetCore.Repository.Interfaces
{
    public interface IHeroesRepository
    {
        Hero GetHeroById(int id);
        IList<Hero> GetHeroes(string searchString, int startIndex, int limit);
        int GetHeroesCount(string searchString);
    }
}
