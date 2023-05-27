using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyVoteTime.Server.Migrations
{
    /// <inheritdoc />
    public partial class thirdState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isPublic",
                schema: "dbo",
                table: "Competition");

            migrationBuilder.AddColumn<int>(
                name: "State",
                schema: "dbo",
                table: "Competition",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                schema: "dbo",
                table: "Competition");

            migrationBuilder.AddColumn<bool>(
                name: "isPublic",
                schema: "dbo",
                table: "Competition",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
