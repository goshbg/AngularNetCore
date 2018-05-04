using System.Collections.Generic;
using System.Linq;
using AngularNetCore.DataAccess.Models;
using AngularNetCore.Repository.Interfaces;

namespace AngularNetCore.Repository.Implementation
{
    public class HeroesRepository : IHeroesRepository
    {
        private readonly AngularnetcoreContext _context;

        public HeroesRepository(AngularnetcoreContext context)
        {
            _context = context;
        }

        public Hero GetHeroById(int id)
        {
            return _context.Heroes.FirstOrDefault(h => h.Id == id);
        }

        public IList<Hero> GetHeroes(string searchString, int currentPage, int itemsPerPage)
        {
            var heroes = GetHeroesQuery(searchString);
            return heroes.OrderBy(h=>h.Id).Skip((currentPage-1)*itemsPerPage).Take(itemsPerPage).ToList();
        }

        public int GetHeroesCount(string searchString)
        {
            var heroes = GetHeroesQuery(searchString);
            return heroes.Count();
        }

        private IQueryable<Hero> GetHeroesQuery(string searchString)
        {
            var heroes = _context.Heroes.AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
                heroes = heroes.Where(h => h.Name.ToLower().Contains(searchString.ToLower()));
            }

            return heroes;
        }
    }
}
