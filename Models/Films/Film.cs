using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace akimedia_server.Models.Films
{
    public class Film
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(500)]
        public string Title { get; set; }

        public int DirectorId { get; set; }

        [Required]
        public FilmDirector Director { get; set; }
        
        public int Year { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public IList<FilmFilmGenre> FilmFilmGenres { get; set; }

        public string Logo { get; set; }

        [MinLength(50)]
        public string Description { get; set; }

        public int? Rating { get; set; }

        public Film()
        {
            FilmFilmGenres = new List<FilmFilmGenre>();
        }
        
    }
}