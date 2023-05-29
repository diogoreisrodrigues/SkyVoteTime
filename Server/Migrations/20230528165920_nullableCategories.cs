using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyVoteTime.Server.Migrations
{
    /// <inheritdoc />
    public partial class nullableCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Competition_CompetitionId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Person_PersonId",
                table: "Votes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Persons");

            migrationBuilder.RenameIndex(
                name: "IX_Person_CompetitionId",
                table: "Persons",
                newName: "IX_Persons_CompetitionId");

            migrationBuilder.AlterColumn<string>(
                name: "CategoriesJson",
                schema: "dbo",
                table: "Competition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Competition_CompetitionId",
                table: "Persons",
                column: "CompetitionId",
                principalSchema: "dbo",
                principalTable: "Competition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Persons_PersonId",
                table: "Votes",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Competition_CompetitionId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Persons_PersonId",
                table: "Votes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_CompetitionId",
                table: "Person",
                newName: "IX_Person_CompetitionId");

            migrationBuilder.AlterColumn<string>(
                name: "CategoriesJson",
                schema: "dbo",
                table: "Competition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Competition_CompetitionId",
                table: "Person",
                column: "CompetitionId",
                principalSchema: "dbo",
                principalTable: "Competition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Person_PersonId",
                table: "Votes",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");
        }
    }
}
