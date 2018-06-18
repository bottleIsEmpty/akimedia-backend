using Microsoft.EntityFrameworkCore.Migrations;

namespace akimediaserver.Migrations
{
    public partial class SeedFilmGenresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('аниме')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('биографический')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('боевик')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('вестерн')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('военный')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('детектив')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('детский')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('документальный')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('драма')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('исторический')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('кинокомикс')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('комедия')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('концерт')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('короткометражный')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('криминал')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('мелодрама')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('мистика')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('музыка')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('мультфильм')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('мюзикл')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('научный')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('приключения')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('реалити-шоу')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('семейный')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('спорт')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('ток-шоу')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('триллер')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('ужасы')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('фантастика')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('фильм-нуар')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('фэнтези')");
            migrationBuilder.Sql("INSERT INTO FilmGenres (GenreName) VALUES ('эротика')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM FilmGenres");
        }
    }
}
