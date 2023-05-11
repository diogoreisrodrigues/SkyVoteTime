using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyVoteTime.Server.Migrations
{
    /// <inheritdoc />
    public partial class isPublic1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "isPublic",
                schema: "dbo",
                table: "Competition",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isPublic",
                schema: "dbo",
                table: "Competition",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
