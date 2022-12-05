using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sneakersshop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin_Models",
                columns: table => new
                {
                    AdId = table.Column<int>(name: "Ad_Id", type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdSurename = table.Column<string>(name: "Ad_Surename", type: "TEXT", maxLength: 50, nullable: false),
                    AdPassword = table.Column<string>(name: "Ad_Password", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin_Models", x => x.AdId);
                });

            migrationBuilder.CreateTable(
                name: "user_Models",
                columns: table => new
                {
                    UId = table.Column<int>(name: "U_Id", type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UName = table.Column<string>(name: "U_Name", type: "TEXT", maxLength: 50, nullable: false),
                    UEmail = table.Column<string>(name: "U_Email", type: "TEXT", maxLength: 50, nullable: false),
                    UPassword = table.Column<string>(name: "U_Password", type: "TEXT", maxLength: 50, nullable: false),
                    UPhone = table.Column<string>(name: "U_Phone", type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_Models", x => x.UId);
                });

            migrationBuilder.CreateTable(
                name: "category_Models",
                columns: table => new
                {
                    CatgId = table.Column<int>(name: "Catg_Id", type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CatgName = table.Column<string>(name: "Catg_Name", type: "TEXT", nullable: false),
                    AdminFKId = table.Column<int>(name: "Admin_FK_Id", type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_Models", x => x.CatgId);
                    table.ForeignKey(
                        name: "FK_category_Models_admin_Models_Admin_FK_Id",
                        column: x => x.AdminFKId,
                        principalTable: "admin_Models",
                        principalColumn: "Ad_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produkcjaButow_Models",
                columns: table => new
                {
                    ProdId = table.Column<int>(name: "Prod_Id", type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProdMarka = table.Column<string>(name: "Prod_Marka", type: "TEXT", maxLength: 50, nullable: false),
                    ProdModel = table.Column<string>(name: "Prod_Model", type: "TEXT", maxLength: 50, nullable: false),
                    ProdRodzaj = table.Column<int>(name: "Prod_Rodzaj", type: "INTEGER", nullable: false),
                    ProdKolor = table.Column<int>(name: "Prod_Kolor", type: "INTEGER", nullable: false),
                    ProdCena = table.Column<double>(name: "Prod_Cena", type: "REAL", nullable: false),
                    ProdImage = table.Column<string>(name: "Prod_Image", type: "TEXT", nullable: false),
                    CategoryFKId = table.Column<int>(name: "Category_FK_Id", type: "INTEGER", nullable: false),
                    UserFKId = table.Column<int>(name: "User_FK_Id", type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produkcjaButow_Models", x => x.ProdId);
                    table.ForeignKey(
                        name: "FK_produkcjaButow_Models_category_Models_Category_FK_Id",
                        column: x => x.CategoryFKId,
                        principalTable: "category_Models",
                        principalColumn: "Catg_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produkcjaButow_Models_user_Models_User_FK_Id",
                        column: x => x.UserFKId,
                        principalTable: "user_Models",
                        principalColumn: "U_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "admin_Models",
                columns: new[] { "Ad_Id", "Ad_Password", "Ad_Surename" },
                values: new object[,]
                {
                    { 1, "admin123", "root" },
                    { 2, "admin123", "admin" },
                    { 3, "admin123", "test" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_category_Models_Admin_FK_Id",
                table: "category_Models",
                column: "Admin_FK_Id");

            migrationBuilder.CreateIndex(
                name: "IX_produkcjaButow_Models_Category_FK_Id",
                table: "produkcjaButow_Models",
                column: "Category_FK_Id");

            migrationBuilder.CreateIndex(
                name: "IX_produkcjaButow_Models_User_FK_Id",
                table: "produkcjaButow_Models",
                column: "User_FK_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produkcjaButow_Models");

            migrationBuilder.DropTable(
                name: "category_Models");

            migrationBuilder.DropTable(
                name: "user_Models");

            migrationBuilder.DropTable(
                name: "admin_Models");
        }
    }
}
