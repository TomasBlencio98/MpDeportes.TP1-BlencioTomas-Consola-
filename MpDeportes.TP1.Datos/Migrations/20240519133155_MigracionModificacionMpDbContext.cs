using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MpDeportes.TP1.Datos.Migrations
{
    /// <inheritdoc />
    public partial class MigracionModificacionMpDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shoe_Brands_BrandId",
                table: "Shoe");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoe_Color_ColorId",
                table: "Shoe");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoe_Genre_GenreId",
                table: "Shoe");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoe_Sport_SportId",
                table: "Shoe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sport",
                table: "Sport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shoe",
                table: "Shoe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Color",
                table: "Color");

            migrationBuilder.RenameTable(
                name: "Sport",
                newName: "Sports");

            migrationBuilder.RenameTable(
                name: "Shoe",
                newName: "Shoes");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "Color",
                newName: "Colors");

            migrationBuilder.RenameIndex(
                name: "IX_Sport_SportName",
                table: "Sports",
                newName: "IX_Sports_SportName");

            migrationBuilder.RenameIndex(
                name: "IX_Shoe_SportId",
                table: "Shoes",
                newName: "IX_Shoes_SportId");

            migrationBuilder.RenameIndex(
                name: "IX_Shoe_Model_Description_Price",
                table: "Shoes",
                newName: "IX_Shoes_Model_Description_Price");

            migrationBuilder.RenameIndex(
                name: "IX_Shoe_GenreId",
                table: "Shoes",
                newName: "IX_Shoes_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Shoe_ColorId",
                table: "Shoes",
                newName: "IX_Shoes_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Shoe_BrandId",
                table: "Shoes",
                newName: "IX_Shoes_BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Genre_GenreName",
                table: "Genres",
                newName: "IX_Genres_GenreName");

            migrationBuilder.RenameIndex(
                name: "IX_Color_ColorName",
                table: "Colors",
                newName: "IX_Colors_ColorName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sports",
                table: "Sports",
                column: "SportId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shoes",
                table: "Shoes",
                column: "ShoeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colors",
                table: "Colors",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Brands_BrandId",
                table: "Shoes",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Colors_ColorId",
                table: "Shoes",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Genres_GenreId",
                table: "Shoes",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Sports_SportId",
                table: "Shoes",
                column: "SportId",
                principalTable: "Sports",
                principalColumn: "SportId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Brands_BrandId",
                table: "Shoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Colors_ColorId",
                table: "Shoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Genres_GenreId",
                table: "Shoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Sports_SportId",
                table: "Shoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sports",
                table: "Sports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shoes",
                table: "Shoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colors",
                table: "Colors");

            migrationBuilder.RenameTable(
                name: "Sports",
                newName: "Sport");

            migrationBuilder.RenameTable(
                name: "Shoes",
                newName: "Shoe");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.RenameTable(
                name: "Colors",
                newName: "Color");

            migrationBuilder.RenameIndex(
                name: "IX_Sports_SportName",
                table: "Sport",
                newName: "IX_Sport_SportName");

            migrationBuilder.RenameIndex(
                name: "IX_Shoes_SportId",
                table: "Shoe",
                newName: "IX_Shoe_SportId");

            migrationBuilder.RenameIndex(
                name: "IX_Shoes_Model_Description_Price",
                table: "Shoe",
                newName: "IX_Shoe_Model_Description_Price");

            migrationBuilder.RenameIndex(
                name: "IX_Shoes_GenreId",
                table: "Shoe",
                newName: "IX_Shoe_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Shoes_ColorId",
                table: "Shoe",
                newName: "IX_Shoe_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Shoes_BrandId",
                table: "Shoe",
                newName: "IX_Shoe_BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Genres_GenreName",
                table: "Genre",
                newName: "IX_Genre_GenreName");

            migrationBuilder.RenameIndex(
                name: "IX_Colors_ColorName",
                table: "Color",
                newName: "IX_Color_ColorName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sport",
                table: "Sport",
                column: "SportId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shoe",
                table: "Shoe",
                column: "ShoeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Color",
                table: "Color",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoe_Brands_BrandId",
                table: "Shoe",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoe_Color_ColorId",
                table: "Shoe",
                column: "ColorId",
                principalTable: "Color",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoe_Genre_GenreId",
                table: "Shoe",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoe_Sport_SportId",
                table: "Shoe",
                column: "SportId",
                principalTable: "Sport",
                principalColumn: "SportId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
