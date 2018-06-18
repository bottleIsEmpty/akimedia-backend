using Microsoft.EntityFrameworkCore.Migrations;

namespace akimediaserver.Migrations
{
    public partial class SeedDirectorsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO FilmDirectors (Name, Surname, BornYear, Country) VALUES ('Квентин', 'Тарантино', '1963', 'США')");
            migrationBuilder.Sql("INSERT INTO FilmDirectors (Name, Surname, BornYear, Country) VALUES ('Кристофер', 'Нолан', '1970', 'Великобритания')");
            migrationBuilder.Sql("INSERT INTO FilmDirectors (Name, Surname, BornYear, DeathYear, Country) VALUES ('Стэнли', 'Кубрик', '1928', '1999', 'США')");
            migrationBuilder.Sql("INSERT INTO FilmDirectors (Name, Surname, BornYear, Country) VALUES ('Стивен', 'Спилберг', '1946', 'США')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM FilmDirectors");
        }
    }
}
