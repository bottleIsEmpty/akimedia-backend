using Microsoft.EntityFrameworkCore.Migrations;

namespace akimediaserver.Migrations
{
    public partial class AddTotalFilmsToFilmDirector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalFilms",
                table: "FilmDirectors",
                nullable: true,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalFilms",
                table: "FilmDirectors");
        }
    }
}
