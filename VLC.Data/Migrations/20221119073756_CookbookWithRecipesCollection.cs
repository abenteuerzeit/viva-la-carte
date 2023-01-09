using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VLC.Data.Migrations
{
    public partial class CookbookWithRecipesCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Cookbooks_CookbookId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_CookbookId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CookbookId",
                table: "Recipes");

            migrationBuilder.AlterColumn<string>(
                name: "Label",
                table: "Cookbooks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "CookbookRecipe",
                columns: table => new
                {
                    CookbooksId = table.Column<int>(type: "int", nullable: false),
                    RecipesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookbookRecipe", x => new { x.CookbooksId, x.RecipesId });
                    table.ForeignKey(
                        name: "FK_CookbookRecipe_Cookbooks_CookbooksId",
                        column: x => x.CookbooksId,
                        principalTable: "Cookbooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CookbookRecipe_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CookbookRecipe_RecipesId",
                table: "CookbookRecipe",
                column: "RecipesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CookbookRecipe");

            migrationBuilder.AddColumn<int>(
                name: "CookbookId",
                table: "Recipes",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Label",
                table: "Cookbooks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
    }
}
