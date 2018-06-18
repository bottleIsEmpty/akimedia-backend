namespace akimedia_server.Controllers.Resources.Films
{
    public class FilmDirectorResource
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Surname { get; set; }
        
        public int? BornYear { get; set; }

        public int? DeathYear { get; set; }

        public string Country { get; set; }

        public string Photo { get; set; }
    }
}