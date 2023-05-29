using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyVoteTime.Server.Migrations
{
    /// <inheritdoc />
    public partial class ActorsList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Votes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Votes_PersonId",
                table: "Votes",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Person_PersonId",
                table: "Votes",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Person_PersonId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_PersonId",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Votes");
        }
    }
}
