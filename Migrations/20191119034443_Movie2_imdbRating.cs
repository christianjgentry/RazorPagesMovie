using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMovie.Migrations
{
    public partial class Movie2_imdbRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie2",
                columns: table => new
                {
                    imdbID = table.Column<string>(nullable: false),
                    Poster = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Rated = table.Column<string>(nullable: true),
                    Runtime = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    imdbRating = table.Column<string>(nullable: true),
                    Metascore = table.Column<string>(nullable: true),
                    BoxOffice = table.Column<string>(nullable: true),
                    Actors = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Production = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie2", x => x.imdbID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie2");
        }
    }
}
