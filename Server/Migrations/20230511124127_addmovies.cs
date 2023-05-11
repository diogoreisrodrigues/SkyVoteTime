using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyVoteTime.Server.Migrations
{
    /// <inheritdoc />
    public partial class addmovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Competition_CompetitionId",
                table: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_CompetitionId",
                table: "Movies",
                newName: "IX_Movies_CompetitionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Competition_CompetitionId",
                table: "Movies",
                column: "CompetitionId",
                principalSchema: "dbo",
                principalTable: "Competition",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Competition_CompetitionId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CompetitionId",
                table: "Movie",
                newName: "IX_Movie_CompetitionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Competition_CompetitionId",
                table: "Movie",
                column: "CompetitionId",
                principalSchema: "dbo",
                principalTable: "Competition",
                principalColumn: "Id");
        }
    }
}
