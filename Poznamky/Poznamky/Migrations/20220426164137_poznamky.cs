using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poznamky.Migrations
{
    public partial class poznamky : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Novinky",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nadpis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CasPridani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    jmeno_uzivatele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dulezita_poznamka = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novinky", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pristup",
                columns: table => new
                {
                    jmeno_uzivatele = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    heslo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pristup", x => x.jmeno_uzivatele);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Novinky");

            migrationBuilder.DropTable(
                name: "Pristup");
        }
    }
}
