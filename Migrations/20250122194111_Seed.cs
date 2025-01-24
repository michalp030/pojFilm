using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace film_zad.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kategoria",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Komedia" },
                    { 2, "Dokument" },
                    { 3, "Dramat" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Description", "KategoriaId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Niezła impreza", 1, "Kac Vegas", 50 },
                    { 2, "Chyba nie dolecą", 2, "Lot 93", 40 },
                    { 3, "Wojna, strzelanie, śmierć", 3, "Furia", 60 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kategoria",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kategoria",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kategoria",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
