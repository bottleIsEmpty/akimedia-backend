using System.Collections.Generic;
using System.Threading.Tasks;
using akimedia_server.Controllers.Resources.Films;
using akimedia_server.Models.Films;
using akimedia_server.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace akimedia_server.Controllers.Films
{
    [ApiController]
    [Route("/api/films/directors")]
    public class FilmDirectorsController : ControllerBase
    {
        private readonly AkimediaDbContext context;
        public readonly IMapper mapper;
        private readonly IHostingEnvironment host;

        public FilmDirectorsController(
            AkimediaDbContext context, 
            IMapper mapper, 
            IHostingEnvironment host
        )
        {
            this.mapper = mapper;
            this.host = host;
            this.context = context;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetDirectors(string query)
        {
            var dbQuery = context.FilmDirectors.AsQueryable();
            if (query != null)
            {
                dbQuery = dbQuery.Where(d => d.Name.Contains(query) || d.Surname.Contains(query));
            }
                
            var directors = await dbQuery.ToListAsync();
            
            return Ok(mapper.Map<List<FilmDirector>, List<FilmDirectorResource>>(directors));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDirector(int? id)
        {
            var director = await context.FilmDirectors.FindAsync(id);

            if (director == null)
                return NotFound();

            var directorResource = mapper.Map<FilmDirector, FilmDirectorResource>(director);

            return Ok(directorResource);
        }

        [HttpPost]
        public async Task<IActionResult> AddDirector([FromBody] FilmDirectorResource directorResource, IFormFile photo)
        {
            var director = mapper.Map<FilmDirectorResource, FilmDirector>(directorResource);

            await context.AddAsync(director);
            await context.SaveChangesAsync();

            return Ok(mapper.Map<FilmDirector, FilmDirectorResource>(director));
        }

        [HttpPost("{id}/photo")]
        public async Task<IActionResult> AddPhoto(int id, IFormFile photo)
        {
            if (photo == null)
                return BadRequest();

            var director = await context.FilmDirectors.FindAsync(id);

            if (director == null)
                return NotFound(id);

            director.Photo = await PhotoLoader.addPhoto("film-director", photo, host.WebRootPath);

            await context.SaveChangesAsync();

            return Ok();
                
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var director = await context.FilmDirectors.FindAsync(id);

            if (director == null)
                return NotFound();

            context.Remove(director);
            await context.SaveChangesAsync();           

            return Ok(id);
        }
    }
}