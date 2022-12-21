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
                name: "Buty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Markabutów = table.Column<string>(name: "Marka butów", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Modelbutów = table.Column<string>(name: "Model butów", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cenabutów = table.Column<double>(name: "Cena butów", type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buty", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buty");
        }
    }
}
