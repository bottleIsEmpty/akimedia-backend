using System.Collections.Generic;
using System.Linq;
using akimedia_server.Controllers.Resources.Films;
using akimedia_server.Models.Films;
using akimedia_server.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace akimedia_server.Controllers
{
    [Route("/api/genres")]
    public class GenresController : Controller
    {
        private readonly AkimediaDbContext context;
        private readonly IMapper mapper;

        public GenresController(AkimediaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult getGenres(string type)
        {
            if (type == "film")
            {
                var genres = context.FilmGenres.ToList();
                return Ok(mapper.Map<List<FilmGenre>, List<FilmGenreResource>>(genres)); 
            }                
             
            return NotFound();
        }
    }
}