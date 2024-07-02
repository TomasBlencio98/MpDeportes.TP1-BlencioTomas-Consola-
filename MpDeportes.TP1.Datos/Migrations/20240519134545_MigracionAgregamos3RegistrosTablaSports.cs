﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MpDeportes.TP1.Datos.Migrations
{
    /// <inheritdoc />
    public partial class MigracionAgregamos3RegistrosTablaSports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportId", "SportName" },
                values: new object[,]
                {
                    { 1, "Running" },
                    { 2, "Basketball" },
                    { 3, "Soccer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "SportId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "SportId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "SportId",
                keyValue: 3);
        }
    }
}
