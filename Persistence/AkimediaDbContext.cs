using akimedia_server.Models.Films;
using Microsoft.EntityFrameworkCore;

namespace akimedia_server.Persistence
{
    public class AkimediaDbContext : DbContext
    {
        public DbSet<FilmDirector> FilmDirectors { get; set; }

        public DbSet<Film> Films { get; set; }

        public DbSet<FilmGenre> FilmGenres { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<FilmDirector>()
                .Property(d => d.TotalFilms)
                .HasDefaultValue(0);

            modelBuilder.Entity<Film>()
                .Property(f => f.Rating)
                .HasDefaultValue(0);

            modelBuilder.Entity<FilmFilmGenre>()
                .HasKey(ffg => new { ffg.FilmId, ffg.FilmGenreId });

            modelBuilder.Entity<FilmFilmGenre>()
                .HasOne(ffg => ffg.Film)
                .WithMany(f => f.FilmFilmGenres)
                .HasForeignKey(ffg => ffg.FilmId);

            modelBuilder.Entity<FilmFilmGenre>()
                .HasOne(ffg => ffg.FilmGenre)
                .WithMany(fg => fg.FilmFilmGenres)
                .HasForeignKey(ffg => ffg.FilmGenreId);
        }

        public AkimediaDbContext(DbContextOptions<AkimediaDbContext> options)
            : base(options)
        {}
        
    }
}

