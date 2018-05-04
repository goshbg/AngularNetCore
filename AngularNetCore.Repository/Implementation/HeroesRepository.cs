using System.Collections.Generic;
using System.Linq;
using AngularNetCore.DataAccess.Models;
using AngularNetCore.Dto;
using AngularNetCore.Repository.Interfaces;
using AutoMapper;

namespace AngularNetCore.Repository.Implementation
{
    public class HeroesRepository : IHeroesRepository
    {
        private readonly AngularnetcoreContext _context;
        private readonly IMapper _mapper;

        public HeroesRepository(AngularnetcoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public HeroDto GetHeroById(int id)
        {
            var heroEntity = _context.Heroes.FirstOrDefault(h => h.Id == id);
            var heroDto = _mapper.Map<HeroDto>(heroEntity);
            return heroDto;
        }

        public IList<HeroDto> GetHeroes(string searchString, int currentPage, int itemsPerPage)
        {
            var heroes = GetHeroesQuery(searchString).OrderBy(h => h.Id).Skip((currentPage - 1) * itemsPerPage).Take(itemsPerPage).ToList();

            var heroesDto = _mapper.Map<List<HeroDto>>(heroes);
            return heroesDto;
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
