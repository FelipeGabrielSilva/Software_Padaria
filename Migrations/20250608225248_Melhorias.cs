using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WindowsForm_Padaria.Migrations
{
    /// <inheritdoc />
    public partial class Melhorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProdutosId",
                table: "Venda");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoUnitario",
                table: "Venda_Produto",
                type: "decimal(9,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Venda",
                type: "decimal(9,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF_CNPJ",
                table: "Venda",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "PagamentoId",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagamentoId",
                table: "Fornecedor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_PagamentoId",
                table: "Venda",
                column: "PagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Receita_ProdutoId",
                table: "Produto_Receita",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Receita_ReceitaId",
                table: "Produto_Receita",
                column: "ReceitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Padaria_Produto_CategoriaId",
                table: "Padaria_Produto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Padaria_Prod_Receita_ProdutoId",
                table: "Padaria_Prod_Receita",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Padaria_Prod_Receita_ReceitaId",
                table: "Padaria_Prod_Receita",
                column: "ReceitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_Produto_FornecedorId",
                table: "Fornecedor_Produto",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_PagamentoId",
                table: "Fornecedor",
                column: "PagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoque_Prod_Padaria_ProdutoId",
                table: "Estoque_Prod_Padaria",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoque_Prod_Fornecedor_FornecedorId",
                table: "Estoque_Prod_Fornecedor",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoque_Prod_Fornecedor_ProdutoId",
                table: "Estoque_Prod_Fornecedor",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estoque_Prod_Fornecedor_Fornecedor_FornecedorId",
                table: "Estoque_Prod_Fornecedor",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estoque_Prod_Fornecedor_Fornecedor_Produto_ProdutoId",
                table: "Estoque_Prod_Fornecedor",
                column: "ProdutoId",
                principalTable: "Fornecedor_Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estoque_Prod_Padaria_Padaria_Produto_ProdutoId",
                table: "Estoque_Prod_Padaria",
                column: "ProdutoId",
                principalTable: "Padaria_Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Pagamento_PagamentoId",
                table: "Fornecedor",
                column: "PagamentoId",
                principalTable: "Pagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Produto_Fornecedor_FornecedorId",
                table: "Fornecedor_Produto",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Padaria_Prod_Receita_Padaria_Produto_ProdutoId",
                table: "Padaria_Prod_Receita",
                column: "ProdutoId",
                principalTable: "Padaria_Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Padaria_Prod_Receita_Receita_ReceitaId",
                table: "Padaria_Prod_Receita",
                column: "ReceitaId",
                principalTable: "Receita",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Padaria_Produto_Categoria_CategoriaId",
                table: "Padaria_Produto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Receita_Padaria_Produto_ProdutoId",
                table: "Produto_Receita",
                column: "ProdutoId",
                principalTable: "Padaria_Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Receita_Receita_ReceitaId",
                table: "Produto_Receita",
                column: "ReceitaId",
                principalTable: "Receita",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Pagamento_PagamentoId",
                table: "Venda",
                column: "PagamentoId",
                principalTable: "Pagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estoque_Prod_Fornecedor_Fornecedor_FornecedorId",
                table: "Estoque_Prod_Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Estoque_Prod_Fornecedor_Fornecedor_Produto_ProdutoId",
                table: "Estoque_Prod_Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Estoque_Prod_Padaria_Padaria_Produto_ProdutoId",
                table: "Estoque_Prod_Padaria");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Pagamento_PagamentoId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Produto_Fornecedor_FornecedorId",
                table: "Fornecedor_Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Padaria_Prod_Receita_Padaria_Produto_ProdutoId",
                table: "Padaria_Prod_Receita");

            migrationBuilder.DropForeignKey(
                name: "FK_Padaria_Prod_Receita_Receita_ReceitaId",
                table: "Padaria_Prod_Receita");

            migrationBuilder.DropForeignKey(
                name: "FK_Padaria_Produto_Categoria_CategoriaId",
                table: "Padaria_Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Receita_Padaria_Produto_ProdutoId",
                table: "Produto_Receita");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Receita_Receita_ReceitaId",
                table: "Produto_Receita");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Pagamento_PagamentoId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_PagamentoId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Produto_Receita_ProdutoId",
                table: "Produto_Receita");

            migrationBuilder.DropIndex(
                name: "IX_Produto_Receita_ReceitaId",
                table: "Produto_Receita");

            migrationBuilder.DropIndex(
                name: "IX_Padaria_Produto_CategoriaId",
                table: "Padaria_Produto");

            migrationBuilder.DropIndex(
                name: "IX_Padaria_Prod_Receita_ProdutoId",
                table: "Padaria_Prod_Receita");

            migrationBuilder.DropIndex(
                name: "IX_Padaria_Prod_Receita_ReceitaId",
                table: "Padaria_Prod_Receita");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedor_Produto_FornecedorId",
                table: "Fornecedor_Produto");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedor_PagamentoId",
                table: "Fornecedor");

            migrationBuilder.DropIndex(
                name: "IX_Estoque_Prod_Padaria_ProdutoId",
                table: "Estoque_Prod_Padaria");

            migrationBuilder.DropIndex(
                name: "IX_Estoque_Prod_Fornecedor_FornecedorId",
                table: "Estoque_Prod_Fornecedor");

            migrationBuilder.DropIndex(
                name: "IX_Estoque_Prod_Fornecedor_ProdutoId",
                table: "Estoque_Prod_Fornecedor");

            migrationBuilder.DropColumn(
                name: "PagamentoId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "PagamentoId",
                table: "Fornecedor");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoUnitario",
                table: "Venda_Produto",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Venda",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,2)");

            migrationBuilder.UpdateData(
                table: "Venda",
                keyColumn: "CPF_CNPJ",
                keyValue: null,
                column: "CPF_CNPJ",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CPF_CNPJ",
                table: "Venda",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ProdutosId",
                table: "Venda",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
