using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzariaRioClaro.Migrations
{
    public partial class Alterações : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ingredientes",
                table: "Sabores",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Preco",
                table: "Sabores",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredientes",
                table: "Sabores");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Sabores");
        }
    }
}
