using System.Collections.Generic;
using System.Threading.Tasks;
using akimedia_server.Controllers.Resources.Films;
using akimedia_server.Models.Films;
using akimedia_server.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace akimedia_server.Controllers.Films
{
    [Route("/api/films/directors")]
    public class FilmDirectorsController : Controller
    {
        private readonly AkimediaDbContext context;
        public readonly IMapper mapper;
        public FilmDirectorsController(AkimediaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var directors = await context.FilmDirectors.ToListAsync();
            return Ok(mapper.Map<List<FilmDirector>, List<FilmDirectorResource>>(directors));
        
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var director = await context.FilmDirectors.FindAsync(id);

            if (director == null)
                return NotFound();

            var directorResource = mapper.Map<FilmDirector, FilmDirectorResource>(director);

            return Ok(directorResource);
        }
    }
}