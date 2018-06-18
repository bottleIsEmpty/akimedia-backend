using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace akimedia_server.Controllers.Resources.Films
{
    public class FilmResource
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(500)]
        public string Title { get; set; }

        [Required]
        public FilmDirectorResource Director { get; set; }
        
        public int Year { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public IList<string> Genres { get; set; }

        public string Logo { get; set; }

        [MinLength(50)]
        public string Description { get; set; }

        public int? Rating { get; set; }

        public FilmResource()
        {
            Genres = new List<string>();
        }
    }
}