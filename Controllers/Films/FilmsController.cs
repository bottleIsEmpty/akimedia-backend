using System.Linq;
using akimedia_server.Models.Films;
using akimedia_server.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using akimedia_server.Controllers.Resources.Films;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace akimedia_server.Controllers.Films
{
    [Route("/api/films")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly AkimediaDbContext context;
        private readonly IMapper mapper;
        private readonly ILogger logger;
        private readonly IHostingEnvironment host;

        public FilmsController(AkimediaDbContext context, IMapper mapper, ILogger<FilmsController> logger, IHostingEnvironment host)
        {
            this.logger = logger;
            this.host = host;
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetFilm()
        {
            var films = context.Films
                .Include(f => f.Director)
                .Include(f => f.FilmFilmGenres)
                    .ThenInclude(ffg => ffg.FilmGenre)
                .ToList();
            
            if (films == null)
                return NotFound();

            return Ok(Mapper.Map<List<Film>, List<FilmResource>>(films));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFilm(int id)
        {
            var film = await context.Films
                .Include(f => f.FilmFilmGenres)
                    .ThenInclude(ffg => ffg.FilmGenre)
                .Include(f => f.Director)
                .FirstOrDefaultAsync(f => f.Id == id);
            
            if (film == null)
                return NotFound();

            return Ok(Mapper.Map<Film, FilmResource>(film));
        }

        [HttpPost]
        public async Task<IActionResult> AddFilm([FromBody] EditFilmResource filmResource)
        {
            var film = mapper.Map<EditFilmResource, Film>(filmResource);

            if (!ModelState.IsValid)
                return BadRequest(filmResource);

            var director = await context.FilmDirectors.FindAsync(filmResource.Director);
            director.TotalFilms++;

            await context.Films.AddAsync(film);
            await context.SaveChangesAsync();

            return Ok(mapper.Map<Film, EditFilmResource>(film));
        }

        [HttpPost("{id}/photo")]
        public async Task<IActionResult> AddPhoto(int id, IFormFile photo)
        {
            if (photo == null)
                return BadRequest();

            var film = await context.Films.FindAsync(id);

            if (film == null)
                return NotFound(id);

            film.Logo = await PhotoLoader.addPhoto("film", photo, host.WebRootPath);

            await context.SaveChangesAsync();

            return Ok();
                
        }

    }
}