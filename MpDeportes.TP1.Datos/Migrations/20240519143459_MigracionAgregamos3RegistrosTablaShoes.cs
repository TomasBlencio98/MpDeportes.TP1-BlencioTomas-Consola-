using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MpDeportes.TP1.Datos.Migrations
{
    /// <inheritdoc />
    public partial class MigracionAgregamos3RegistrosTablaShoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "ShoeId", "BrandId", "ColorId", "Description", "GenreId", "Model", "Price", "SportId" },
                values: new object[,]
                {
                    { 1, 1, 1, "Estilo urbano y cultura pop", 1, "Adidas Superstar", 99.99m, 1 },
                    { 2, 2, 2, "Diseñadas para ofrecer estabilidad y versatilidad en cada movimiento", 2, "Nano X1", 129.99m, 2 },
                    { 3, 3, 3, " Opción versátil y cómoda para correr", 3, "Air Zoom ", 79.99m, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 3);
        }
    }
}
