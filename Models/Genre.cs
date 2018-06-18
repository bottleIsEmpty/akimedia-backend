using System.ComponentModel.DataAnnotations;

namespace akimedia_server.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        public string GenreName { get; set; }
    }
}