using System.Collections.Generic;
using AngularNetCore.Models;
using AngularNetCore.Repository.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AngularNetCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Heroes")]
    public class HeroesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IHeroesRepository _heroesRepository;
        public HeroesController(IMapper mapper, IHeroesRepository heroesRepository)
        {
            _mapper = mapper;
            _heroesRepository = heroesRepository;
        }

        [HttpGet]
        public List<HeroModel> GetHeroes(string searchString, int currentPage, int pageSize)
        {
            var heroes = _heroesRepository.GetHeroes(searchString, currentPage, pageSize);
            var heroModels = _mapper.Map<List<HeroModel>>(heroes);
            return heroModels;
        }

        [HttpGet("{id}")]
        public HeroModel GetById(int id)
        {
            var hero = _heroesRepository.GetHeroById(id);
            var heroModel = _mapper.Map<HeroModel>(hero);
            return heroModel;
        }
    }
}