using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Api.Migrations
{
    public partial class SegundaVersao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoItens_Carrinhos_CarrinhoID",
                table: "CarrinhoItens");

            migrationBuilder.RenameColumn(
                name: "CarrinhoID",
                table: "CarrinhoItens",
                newName: "CarrinhoId");

            migrationBuilder.RenameIndex(
                name: "IX_CarrinhoItens_CarrinhoID",
                table: "CarrinhoItens",
                newName: "IX_CarrinhoItens_CarrinhoId");

            migrationBuilder.AlterColumn<string>(
                name: "PessoaId",
                table: "Carrinhos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoItens_Carrinhos_CarrinhoId",
                table: "CarrinhoItens",
                column: "CarrinhoId",
                principalTable: "Carrinhos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoItens_Carrinhos_CarrinhoId",
                table: "CarrinhoItens");

            migrationBuilder.RenameColumn(
                name: "CarrinhoId",
                table: "CarrinhoItens",
                newName: "CarrinhoID");

            migrationBuilder.RenameIndex(
                name: "IX_CarrinhoItens_CarrinhoId",
                table: "CarrinhoItens",
                newName: "IX_CarrinhoItens_CarrinhoID");

            migrationBuilder.AlterColumn<int>(
                name: "PessoaId",
                table: "Carrinhos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoItens_Carrinhos_CarrinhoID",
                table: "CarrinhoItens",
                column: "CarrinhoID",
                principalTable: "Carrinhos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
