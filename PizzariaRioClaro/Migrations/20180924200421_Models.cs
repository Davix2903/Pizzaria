using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzariaRioClaro.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sabor",
                table: "Sabores",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ingredientes",
                table: "Sabores",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Preco",
                table: "Refrigerantes",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Refrigerantes");

            migrationBuilder.AlterColumn<string>(
                name: "Sabor",
                table: "Sabores",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Ingredientes",
                table: "Sabores",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
