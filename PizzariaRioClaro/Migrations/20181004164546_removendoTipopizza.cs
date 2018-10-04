using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzariaRioClaro.Migrations
{
    public partial class removendoTipopizza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoPizza",
                table: "SaboresDoce");

            migrationBuilder.DropColumn(
                name: "TipoPizza",
                table: "Sabores");

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "itensPedidos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "itensPedidos");

            migrationBuilder.AddColumn<string>(
                name: "TipoPizza",
                table: "SaboresDoce",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoPizza",
                table: "Sabores",
                nullable: false,
                defaultValue: "");
        }
    }
}
