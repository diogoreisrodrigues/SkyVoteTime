using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyVoteTime.Server.Migrations
{
    /// <inheritdoc />
    public partial class TotalVotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalVotes",
                schema: "dbo",
                table: "Competition",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalVotes",
                schema: "dbo",
                table: "Competition");
        }
    }
}
