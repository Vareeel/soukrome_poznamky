using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poznamky.Migrations
{
    public partial class migrace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "jmeno_uzivatele",
                table: "Pristup",
                newName: "jmeno");

            migrationBuilder.RenameColumn(
                name: "jmeno_uzivatele",
                table: "Novinky",
                newName: "jmeno");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "jmeno",
                table: "Pristup",
                newName: "jmeno_uzivatele");

            migrationBuilder.RenameColumn(
                name: "jmeno",
                table: "Novinky",
                newName: "jmeno_uzivatele");
        }
    }
}
