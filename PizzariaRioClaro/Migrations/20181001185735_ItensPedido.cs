using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzariaRioClaro.Migrations
{
    public partial class ItensPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RefrigeranteId",
                table: "itensPedidos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaboresDoceId",
                table: "itensPedidos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaboresId",
                table: "itensPedidos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_itensPedidos_RefrigeranteId",
                table: "itensPedidos",
                column: "RefrigeranteId");

            migrationBuilder.CreateIndex(
                name: "IX_itensPedidos_SaboresDoceId",
                table: "itensPedidos",
                column: "SaboresDoceId");

            migrationBuilder.CreateIndex(
                name: "IX_itensPedidos_SaboresId",
                table: "itensPedidos",
                column: "SaboresId");

            migrationBuilder.AddForeignKey(
                name: "FK_itensPedidos_Refrigerantes_RefrigeranteId",
                table: "itensPedidos",
                column: "RefrigeranteId",
                principalTable: "Refrigerantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_itensPedidos_SaboresDoce_SaboresDoceId",
                table: "itensPedidos",
                column: "SaboresDoceId",
                principalTable: "SaboresDoce",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_itensPedidos_Sabores_SaboresId",
                table: "itensPedidos",
                column: "SaboresId",
                principalTable: "Sabores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_itensPedidos_Refrigerantes_RefrigeranteId",
                table: "itensPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_itensPedidos_SaboresDoce_SaboresDoceId",
                table: "itensPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_itensPedidos_Sabores_SaboresId",
                table: "itensPedidos");

            migrationBuilder.DropIndex(
                name: "IX_itensPedidos_RefrigeranteId",
                table: "itensPedidos");

            migrationBuilder.DropIndex(
                name: "IX_itensPedidos_SaboresDoceId",
                table: "itensPedidos");

            migrationBuilder.DropIndex(
                name: "IX_itensPedidos_SaboresId",
                table: "itensPedidos");

            migrationBuilder.DropColumn(
                name: "RefrigeranteId",
                table: "itensPedidos");

            migrationBuilder.DropColumn(
                name: "SaboresDoceId",
                table: "itensPedidos");

            migrationBuilder.DropColumn(
                name: "SaboresId",
                table: "itensPedidos");
        }
    }
}
