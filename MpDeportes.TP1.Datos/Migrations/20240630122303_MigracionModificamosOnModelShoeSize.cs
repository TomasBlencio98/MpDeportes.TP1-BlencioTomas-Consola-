using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MpDeportes.TP1.Datos.Migrations
{
    /// <inheritdoc />
    public partial class MigracionModificamosOnModelShoeSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoesSizes",
                table: "ShoesSizes");

            migrationBuilder.DropIndex(
                name: "IX_ShoesSizes_ShoeId_SizeId",
                table: "ShoesSizes");

            migrationBuilder.AlterColumn<int>(
                name: "ShoeSizeId",
                table: "ShoesSizes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoesSizes",
                table: "ShoesSizes",
                columns: new[] { "ShoeId", "SizeId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoesSizes",
                table: "ShoesSizes");

            migrationBuilder.AlterColumn<int>(
                name: "ShoeSizeId",
                table: "ShoesSizes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoesSizes",
                table: "ShoesSizes",
                column: "ShoeSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesSizes_ShoeId_SizeId",
                table: "ShoesSizes",
                columns: new[] { "ShoeId", "SizeId" },
                unique: true);
        }
    }
}
