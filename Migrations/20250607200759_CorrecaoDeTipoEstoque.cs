using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WindowsForm_Padaria.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoDeTipoEstoque : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProdutosIds",
                table: "Receita");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "Estoque_Prod_Fornecedor",
                newName: "Tipo");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoUnitario",
                table: "Venda_Produto",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Venda",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Padaria_Produto",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Estoque_Prod_Padaria",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Estoque_Prod_Fornecedor",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Estoque_Prod_Fornecedor",
                newName: "tipo");

            migrationBuilder.AlterColumn<float>(
                name: "PrecoUnitario",
                table: "Venda_Produto",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<float>(
                name: "Preco",
                table: "Venda",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AddColumn<string>(
                name: "ProdutosIds",
                table: "Receita",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<float>(
                name: "Preco",
                table: "Padaria_Produto",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<int>(
                name: "Tipo",
                table: "Estoque_Prod_Padaria",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "tipo",
                table: "Estoque_Prod_Fornecedor",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
