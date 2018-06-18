using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace akimedia_server.Models.Films
{
    public class FilmGenre : Genre
    {
        public int FilmId { get; set; }

        public IList<FilmFilmGenre> FilmFilmGenres { get; set; }

        public FilmGenre()
        {
            FilmFilmGenres = new List<FilmFilmGenre>();
        }
    }
}