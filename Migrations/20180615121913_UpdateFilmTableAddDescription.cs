using Microsoft.EntityFrameworkCore.Migrations;

namespace akimediaserver.Migrations
{
    public partial class UpdateFilmTableAddDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Films",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Films",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Films");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Films",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);
        }
    }
}
