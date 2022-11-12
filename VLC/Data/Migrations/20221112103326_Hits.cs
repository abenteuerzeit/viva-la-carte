using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VLC.Data.Migrations
{
    public partial class Hits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Recipe_RecipeId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_MealPlans_MealPlanId",
                table: "Recipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe");

            migrationBuilder.RenameTable(
                name: "Recipe",
                newName: "Recipes");

            migrationBuilder.RenameIndex(
                name: "IX_Recipe_MealPlanId",
                table: "Recipes",
                newName: "IX_Recipes_MealPlanId");

            migrationBuilder.AlterColumn<double>(
                name: "Calories",
                table: "Recipes",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImagesId",
                table: "Recipes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShareAs",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TotalTime",
                table: "Recipes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<double>(
                name: "TotalWeight",
                table: "Recipes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Uri",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Yield",
                table: "Recipes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Measure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Food = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    FoodCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IngredientUnitValue = table.Column<double>(type: "float", nullable: false),
                    IsProductUnitOfMeasruement = table.Column<double>(type: "float", nullable: false),
                    IsInFoodMeasurementUnits = table.Column<bool>(type: "bit", nullable: false),
                    IsInMetricUnits = table.Column<bool>(type: "bit", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredient_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Large",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<long>(type: "bigint", nullable: false),
                    Height = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Large", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Next",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Href = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Next", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThumbnailId = table.Column<int>(type: "int", nullable: true),
                    SmallId = table.Column<int>(type: "int", nullable: true),
                    RegularId = table.Column<int>(type: "int", nullable: true),
                    LargeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Large_LargeId",
                        column: x => x.LargeId,
                        principalTable: "Large",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_Large_RegularId",
                        column: x => x.RegularId,
                        principalTable: "Large",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_Large_SmallId",
                        column: x => x.SmallId,
                        principalTable: "Large",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_Large_ThumbnailId",
                        column: x => x.ThumbnailId,
                        principalTable: "Large",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HitLinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelfId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HitLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HitLinks_Next_SelfId",
                        column: x => x.SelfId,
                        principalTable: "Next",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HitsLinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NextId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HitsLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HitsLinks_Next_NextId",
                        column: x => x.NextId,
                        principalTable: "Next",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RecipeSearches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<long>(type: "bigint", nullable: false),
                    To = table.Column<long>(type: "bigint", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    LinksId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeSearches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeSearches_HitsLinks_LinksId",
                        column: x => x.LinksId,
                        principalTable: "HitsLinks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeId = table.Column<int>(type: "int", nullable: true),
                    LinksId = table.Column<int>(type: "int", nullable: true),
                    HitsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hit_HitLinks_LinksId",
                        column: x => x.LinksId,
                        principalTable: "HitLinks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Hit_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Hit_RecipeSearches_HitsId",
                        column: x => x.HitsId,
                        principalTable: "RecipeSearches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ImagesId",
                table: "Recipes",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Hit_HitsId",
                table: "Hit",
                column: "HitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Hit_LinksId",
                table: "Hit",
                column: "LinksId");

            migrationBuilder.CreateIndex(
                name: "IX_Hit_RecipeId",
                table: "Hit",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_HitLinks_SelfId",
                table: "HitLinks",
                column: "SelfId");

            migrationBuilder.CreateIndex(
                name: "IX_HitsLinks_NextId",
                table: "HitsLinks",
                column: "NextId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_LargeId",
                table: "Images",
                column: "LargeId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_RegularId",
                table: "Images",
                column: "RegularId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_SmallId",
                table: "Images",
                column: "SmallId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ThumbnailId",
                table: "Images",
                column: "ThumbnailId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_RecipeId",
                table: "Ingredient",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeSearches_LinksId",
                table: "RecipeSearches",
                column: "LinksId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Recipes_RecipeId",
                table: "Product",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Images_ImagesId",
                table: "Recipes",
                column: "ImagesId",
                principalTable: "Images",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_MealPlans_MealPlanId",
                table: "Recipes",
                column: "MealPlanId",
                principalTable: "MealPlans",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Recipes_RecipeId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Images_ImagesId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_MealPlans_MealPlanId",
                table: "Recipes");

            migrationBuilder.DropTable(
                name: "Hit");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "HitLinks");

            migrationBuilder.DropTable(
                name: "RecipeSearches");

            migrationBuilder.DropTable(
                name: "Large");

            migrationBuilder.DropTable(
                name: "HitsLinks");

            migrationBuilder.DropTable(
                name: "Next");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_ImagesId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ImagesId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Label",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ShareAs",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "TotalTime",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "TotalWeight",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Uri",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Yield",
                table: "Recipes");

            migrationBuilder.RenameTable(
                name: "Recipes",
                newName: "Recipe");

            migrationBuilder.RenameIndex(
                name: "IX_Recipes_MealPlanId",
                table: "Recipe",
                newName: "IX_Recipe_MealPlanId");

            migrationBuilder.AlterColumn<int>(
                name: "Calories",
                table: "Recipe",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Recipe_RecipeId",
                table: "Product",
                column: "RecipeId",
                principalTable: "Recipe",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_MealPlans_MealPlanId",
                table: "Recipe",
                column: "MealPlanId",
                principalTable: "MealPlans",
                principalColumn: "Id");
        }
    }
}
