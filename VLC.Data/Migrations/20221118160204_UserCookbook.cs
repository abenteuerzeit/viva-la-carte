using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VLC.Data.Migrations
{
    public partial class UserCookbook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Cookbooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cookbooks");
        }
    }
}
