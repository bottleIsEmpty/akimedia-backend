using akimedia_server.Controllers.Resources.Films;
using akimedia_server.Models.Films;
using AutoMapper;

namespace akimedia_server.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FilmDirector, FilmDirectorResource>();    
            CreateMap<FilmDirectorResource, FilmDirector>();    
        }
    }
}