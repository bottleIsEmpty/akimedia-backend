using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace akimediaserver.Migrations
{
    public partial class AddFilmFilmGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "FilmGenres",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    DirectorId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Logo = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Films_FilmDirectors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "FilmDirectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmFilmGenres",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false),
                    FilmGenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmFilmGenres", x => new { x.FilmId, x.FilmGenreId });
                    table.ForeignKey(
                        name: "FK_FilmFilmGenres_FilmGenres_FilmGenreId",
                        column: x => x.FilmGenreId,
                        principalTable: "FilmGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmFilmGenres_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmFilmGenres_FilmGenreId",
                table: "FilmFilmGenres",
                column: "FilmGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_DirectorId",
                table: "Films",
                column: "DirectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmFilmGenres");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "FilmGenres");
        }
    }
}
