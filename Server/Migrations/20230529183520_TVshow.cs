using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyVoteTime.Server.Migrations
{
    /// <inheritdoc />
    public partial class TVshow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "Movies");
        }
    }
}
