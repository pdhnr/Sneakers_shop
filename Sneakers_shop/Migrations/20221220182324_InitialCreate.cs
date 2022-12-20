using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sneakersshop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produkcja butów",
                columns: table => new
                {
                    ProdId = table.Column<int>(name: "Prod_Id", type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Markabutów = table.Column<string>(name: "Marka butów", type: "TEXT", maxLength: 50, nullable: false),
                    Modelbutów = table.Column<string>(name: "Model butów", type: "TEXT", maxLength: 50, nullable: false),
                    Rodzajbutów = table.Column<int>(name: "Rodzaj butów", type: "INTEGER", nullable: false),
                    Kolorbutów = table.Column<int>(name: "Kolor butów", type: "INTEGER", nullable: false),
                    Cenabutów = table.Column<double>(name: "Cena butów", type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkcja butów", x => x.ProdId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produkcja butów");
        }
    }
}
