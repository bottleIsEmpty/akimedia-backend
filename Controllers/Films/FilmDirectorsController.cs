using System.Threading.Tasks;
using akimedia_server.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace akimedia_server.Controllers.Films
{
    // [Route("/api/films/directors")]
    public class FilmDirectorsController : Controller
    {
        private readonly AkimediaDbContext context;
        public FilmDirectorsController(AkimediaDbContext context)
        {
            this.context = context;
        }

        [HttpGet("api/films/directors/")]
        public async Task<IActionResult> Get()
        {
            var directors = await context.FilmDirectors.ToListAsync();
            return Ok(directors);
        }
    }
}