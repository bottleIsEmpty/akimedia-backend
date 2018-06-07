using akimedia_server.Models.Films;
using Microsoft.EntityFrameworkCore;

namespace akimedia_server.Persistence
{
    public class AkimediaDbContext : DbContext
    {
        public AkimediaDbContext(DbContextOptions<AkimediaDbContext> options)
            : base(options)
        {}
        public DbSet<FilmDirector> FilmDirectors { get; set; }  
           
    }
}