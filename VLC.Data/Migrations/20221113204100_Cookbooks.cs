using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VLC.Data.Migrations
{
    public partial class Cookbooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CookbookId",
                table: "Recipes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cookbooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cookbooks", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CookbookId",
                table: "Recipes",
                column: "CookbookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Cookbooks_CookbookId",
                table: "Recipes",
                column: "CookbookId",
                principalTable: "Cookbooks",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Cookbooks_CookbookId",
                table: "Recipes");

            migrationBuilder.DropTable(
                name: "Cookbooks");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_CookbookId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CookbookId",
                table: "Recipes");
        }
    }
}
