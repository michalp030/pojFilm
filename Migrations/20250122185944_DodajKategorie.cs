using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace film_zad.Migrations
{
    /// <inheritdoc />
    public partial class DodajKategorie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategoriaId",
                table: "Films",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Kategoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoria", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_KategoriaId",
                table: "Films",
                column: "KategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Kategoria_KategoriaId",
                table: "Films",
                column: "KategoriaId",
                principalTable: "Kategoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Kategoria_KategoriaId",
                table: "Films");

            migrationBuilder.DropTable(
                name: "Kategoria");

            migrationBuilder.DropIndex(
                name: "IX_Films_KategoriaId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "KategoriaId",
                table: "Films");
        }
    }
}
