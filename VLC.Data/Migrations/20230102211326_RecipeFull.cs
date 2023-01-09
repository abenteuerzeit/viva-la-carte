using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VLC.Data.Migrations
{
    public partial class RecipeFull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Large_LargeId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Large_RegularId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Large_SmallId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Large_ThumbnailId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "Large");

            migrationBuilder.CreateTable(
                name: "Photo",
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
                    table.PrimaryKey("PK_Photo", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Photo_LargeId",
                table: "Images",
                column: "LargeId",
                principalTable: "Photo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Photo_RegularId",
                table: "Images",
                column: "RegularId",
                principalTable: "Photo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Photo_SmallId",
                table: "Images",
                column: "SmallId",
                principalTable: "Photo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Photo_ThumbnailId",
                table: "Images",
                column: "ThumbnailId",
                principalTable: "Photo",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Photo_LargeId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Photo_RegularId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Photo_SmallId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Photo_ThumbnailId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.CreateTable(
                name: "Large",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Height = table.Column<long>(type: "bigint", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Large", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Large_LargeId",
                table: "Images",
                column: "LargeId",
                principalTable: "Large",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Large_RegularId",
                table: "Images",
                column: "RegularId",
                principalTable: "Large",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Large_SmallId",
                table: "Images",
                column: "SmallId",
                principalTable: "Large",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Large_ThumbnailId",
                table: "Images",
                column: "ThumbnailId",
                principalTable: "Large",
                principalColumn: "Id");
        }
    }
}
