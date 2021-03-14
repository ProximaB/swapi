using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWarsMovies.Db.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "MoviesRatings",
                table => new
                {
                    Id = table.Column<int>("INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rating = table.Column<int>("INTEGER", nullable: false),
                    MovieId = table.Column<int>("INTEGER", nullable: false),
                    UserId = table.Column<int>("INTEGER", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_MoviesRatings", x => x.Id); });

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {1, 1, 8, 2});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {27, 1, 1, 18});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {28, 1, 4, 18});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {29, 5, 7, 9});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {30, 2, 1, 2});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {31, 2, 4, 0});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {32, 5, 6, 13});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {33, 5, 9, 0});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {34, 1, 3, 8});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {35, 2, 4, 9});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {36, 2, 3, 3});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {37, 4, 8, 17});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {38, 5, 5, 8});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {39, 2, 6, 13});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {40, 5, 8, 13});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {41, 3, 3, 13});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {42, 4, 1, 8});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {43, 3, 2, 9});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {44, 5, 1, 5});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {45, 5, 1, 2});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {46, 5, 5, 15});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {47, 3, 4, 13});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {26, 1, 9, 1});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {48, 2, 3, 10});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {25, 3, 1, 13});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {23, 5, 6, 4});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {2, 5, 5, 14});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {3, 5, 1, 16});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {4, 4, 7, 5});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {5, 3, 8, 0});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {6, 5, 3, 6});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {7, 1, 9, 12});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {8, 4, 7, 1});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {9, 2, 8, 1});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {10, 2, 4, 2});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {11, 1, 2, 12});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {12, 1, 8, 19});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {13, 4, 5, 5});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {14, 2, 6, 13});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {15, 4, 6, 19});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {16, 2, 7, 13});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {17, 2, 4, 9});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {18, 3, 3, 10});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {19, 1, 7, 10});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {20, 4, 1, 12});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {21, 4, 6, 13});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {22, 3, 7, 14});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {24, 5, 1, 4});

            migrationBuilder.InsertData(
                "MoviesRatings",
                new[] {"Id", "MovieId", "Rating", "UserId"},
                new object[] {49, 5, 3, 8});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "MoviesRatings");
        }
    }
}