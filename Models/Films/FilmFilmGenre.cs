using System.ComponentModel.DataAnnotations.Schema;

namespace akimedia_server.Models.Films
{
    [Table("FilmFilmGenres")]
    public class FilmFilmGenre
    {
        public int FilmId { get; set; }
        public Film Film { get; set; }

        public int FilmGenreId { get; set; }
        public FilmGenre FilmGenre { get; set; }
    }
}