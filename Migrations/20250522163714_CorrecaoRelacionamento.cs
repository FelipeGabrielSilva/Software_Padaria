using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WindowsForm_Padaria.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoRelacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_Fornecedor_Pagamento_TipoPagamentoId",
                table: "Fornecedor");

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
                name: "FK_Produto_Receita_Fornecedor_Produto_ProdutoId",
                table: "Produto_Receita");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Receita_Receita_ReceitaId",
                table: "Produto_Receita");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Pagamento_TipoPagamentoId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_TipoPagamentoId",
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
                name: "IX_Fornecedor_TipoPagamentoId",
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

            migrationBuilder.AddColumn<float>(
                name: "PrecoUnitario",
                table: "Venda_Produto",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Venda_Produto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProdutosId",
                table: "Venda",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "Fornecedor_Produto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tipo",
                table: "Estoque_Prod_Fornecedor",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoUnitario",
                table: "Venda_Produto");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Venda_Produto");

            migrationBuilder.DropColumn(
                name: "ProdutosId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Fornecedor_Produto");

            migrationBuilder.DropColumn(
                name: "tipo",
                table: "Estoque_Prod_Fornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_TipoPagamentoId",
                table: "Venda",
                column: "TipoPagamentoId");

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
                name: "IX_Fornecedor_TipoPagamentoId",
                table: "Fornecedor",
                column: "TipoPagamentoId");

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
                name: "FK_Fornecedor_Pagamento_TipoPagamentoId",
                table: "Fornecedor",
                column: "TipoPagamentoId",
                principalTable: "Pagamento",
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
                name: "FK_Produto_Receita_Fornecedor_Produto_ProdutoId",
                table: "Produto_Receita",
                column: "ProdutoId",
                principalTable: "Fornecedor_Produto",
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
                name: "FK_Venda_Pagamento_TipoPagamentoId",
                table: "Venda",
                column: "TipoPagamentoId",
                principalTable: "Pagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
