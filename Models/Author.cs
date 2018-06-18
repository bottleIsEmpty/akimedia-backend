
using System.ComponentModel.DataAnnotations;

namespace akimedia_server.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Surname { get; set; }
        
        public int? BornYear { get; set; }

        public int? DeathYear { get; set; }

        [Required]
        public string Country { get; set; }

        public string Photo { get; set; }
    }
}