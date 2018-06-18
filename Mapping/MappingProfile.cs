using System.Linq;
using akimedia_server.Controllers.Resources.Films;
using akimedia_server.Models.Films;
using AutoMapper;

namespace akimedia_server.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Models to resources
            CreateMap<FilmDirector, FilmDirectorResource>();    
            CreateMap<FilmGenre, FilmGenreResource>();
            CreateMap<Film, FilmResource>()
                .ForMember(fr => fr.Genres, opt => opt.MapFrom(f => f.FilmFilmGenres.Select(ffg => ffg.FilmGenre.GenreName)));
            CreateMap<Film, EditFilmResource>()
                //.ForMember(f => f.Id, opt => opt.Ignore())
                .ForMember(fr => fr.Genres, opt => opt.MapFrom(f => f.FilmFilmGenres.Select(ffg => ffg.FilmGenreId)));

            // Resources to models
            CreateMap<FilmGenreResource, FilmGenre>();
            CreateMap<FilmDirectorResource, FilmDirector>();   
            CreateMap<EditFilmResource, Film>()
                //.ForMember(f => f.Id, opt => opt.Ignore())
                .ForMember(f => f.FilmFilmGenres, opt => opt.MapFrom(fr => fr.Genres.Select(id => new FilmFilmGenre { FilmGenreId = id, FilmId = fr.Id})));
                           

        }
    }
}