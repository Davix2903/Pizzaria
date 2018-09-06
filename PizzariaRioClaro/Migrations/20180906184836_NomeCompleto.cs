using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzariaRioClaro.Migrations
{
    public partial class NomeCompleto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeCmpleto",
                table: "Pessoas",
                newName: "NomeCompleto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeCompleto",
                table: "Pessoas",
                newName: "NomeCmpleto");
        }
    }
}
