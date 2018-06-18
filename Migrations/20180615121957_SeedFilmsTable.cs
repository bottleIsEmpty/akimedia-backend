using Microsoft.EntityFrameworkCore.Migrations;

namespace akimediaserver.Migrations
{
    public partial class SeedFilmsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO FILMS (Title, DirectorId, Year, Type, Description) VALUES ('Начало', (SELECT Id FROM FilmDirectors WHERE Surname = 'Нолан'), 2010, 'Фильм', 'Кобб — талантливый вор, лучший из лучших в опасном искусстве извлечения: он крадет ценные секреты из глубин подсознания во время сна, когда человеческий разум наиболее уязвим. Редкие способности Кобба сделали его ценным игроком в привычном к предательству мире промышленного шпионажа, но они же превратили его в извечного беглеца и лишили всего, что он когда-либо любил.')");
            migrationBuilder.Sql("INSERT INTO FILMS (Title, DirectorId, Year, Type, Description) VALUES ('Интерстеллар', (SELECT Id FROM FilmDirectors WHERE Surname = 'Нолан'), 2014, 'Фильм', 'Наше время на Земле подошло к концу, команда исследователей берет на себя самую важную миссию в истории человечества; путешествуя за пределами нашей галактики, чтобы узнать есть ли у человечества будущее среди звезд.')");
            migrationBuilder.Sql("INSERT INTO FILMS (Title, DirectorId, Year, Type, Description) VALUES ('Список Шиндлера', (SELECT Id FROM FilmDirectors WHERE Surname = 'Спилберг'), 1993, 'Фильм', 'Лента рассказывает реальную историю загадочного Оскара Шиндлера, члена нацистской партии, преуспевающего фабриканта, спасшего во время Второй мировой войны более тысячи ста евреев. Это триумф одного человека, не похожего на других, и драма тех, кто, благодаря ему, выжил в ужасный период человеческой истории.')");
            migrationBuilder.Sql("INSERT INTO FILMS (Title, DirectorId, Year, Type, Description) VALUES ('Заводной апельсин', (SELECT Id FROM FilmDirectors WHERE Surname = 'Кубрик'), 1971, 'Фильм', 'В фильме был произведен исчерпывающий анализ причин преступности среди молодежи, нетерпимости нового поколения к привычным моральным ценностям и жизненным устоям современного общества.')");
            migrationBuilder.Sql("INSERT INTO FILMS (Title, DirectorId, Year, Type, Description) VALUES ('Криминальное чтиво', (SELECT Id FROM FilmDirectors WHERE Surname = 'Тарантино'), 1994, 'Фильм', 'Двое бандитов Винсент Вега и Джулс Винфилд проводят время в философских беседах в перерыве между разборками и «решением проблем» с должниками своего криминального босса Марселласа Уоллеса. Параллельно разворачивается три истории.')");

            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Начало'), (SELECT Id FROM FilmGenres WHERE GenreName = 'боевик'))");
            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Начало'), (SELECT Id FROM FilmGenres WHERE GenreName = 'криминал'))");
            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Начало'), (SELECT Id FROM FilmGenres WHERE GenreName = 'драма'))");
            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Начало'), (SELECT Id FROM FilmGenres WHERE GenreName = 'фантастика'))");
            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Начало'), (SELECT Id FROM FilmGenres WHERE GenreName = 'триллер'))");
            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Начало'), (SELECT Id FROM FilmGenres WHERE GenreName = 'детектив'))");

            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Интерстеллар'), (SELECT Id FROM FilmGenres WHERE GenreName = 'фантастика'))");
            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Интерстеллар'), (SELECT Id FROM FilmGenres WHERE GenreName = 'драма'))");
            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Интерстеллар'), (SELECT Id FROM FilmGenres WHERE GenreName = 'приключения'))");

            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Список Шиндлера'), (SELECT Id FROM FilmGenres WHERE GenreName = 'драма'))");
            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Список Шиндлера'), (SELECT Id FROM FilmGenres WHERE GenreName = 'биографический'))");
            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Список Шиндлера'), (SELECT Id FROM FilmGenres WHERE GenreName = 'исторический'))");
        
            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Заводной апельсин'), (SELECT Id FROM FilmGenres WHERE GenreName = 'фантастика'))");
            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Заводной апельсин'), (SELECT Id FROM FilmGenres WHERE GenreName = 'драма'))");
            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Заводной апельсин'), (SELECT Id FROM FilmGenres WHERE GenreName = 'криминал'))");

            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Криминальное чтиво'), (SELECT Id FROM FilmGenres WHERE GenreName = 'триллер'))");
            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Криминальное чтиво'), (SELECT Id FROM FilmGenres WHERE GenreName = 'комедия'))");
            migrationBuilder.Sql("INSERT INTO FilmFilmGenres (FilmId, FilmGenreId) VALUES ((SELECT Id FROM Films WHERE Title = 'Криминальное чтиво'), (SELECT Id FROM FilmGenres WHERE GenreName = 'криминал'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Films");
            migrationBuilder.Sql("DELETE FROM FilmFilmGenres");
        }
    }
}
