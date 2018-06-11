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
        public async Task<IActionResult> GetDirectors()
        {
            var directors = await context.FilmDirectors.ToListAsync();
            return Ok(mapper.Map<List<FilmDirector>, List<FilmDirectorResource>>(directors));
        
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDirector(int id)
        {
            var director = await context.FilmDirectors.FindAsync(id);

            if (director == null)
                return NotFound();

            var directorResource = mapper.Map<FilmDirector, FilmDirectorResource>(director);

            return Ok(directorResource);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDirector([FromBody] FilmDirector director) {
            return Ok(director);
        }

        // TODO: PUT 
        [HttpPut("")]
        public IActionResult Put()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var director = await context.FilmDirectors.FindAsync(id);

            if (director == null)
                return BadRequest(); 

            context.FilmDirectors.Remove(director);
            await context.SaveChangesAsync();           

            return Ok();
        }
    }
}