using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyVoteTime.Server.Migrations
{
    /// <inheritdoc />
    public partial class migType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                schema: "dbo",
                table: "Competition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isPublic",
                schema: "dbo",
                table: "Competition",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                schema: "dbo",
                table: "Competition");

            migrationBuilder.DropColumn(
                name: "isPublic",
                schema: "dbo",
                table: "Competition");
        }
    }
}
