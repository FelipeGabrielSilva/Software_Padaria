using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WindowsForm_Padaria.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoCampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProdutosIds",
                table: "Receita",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Categoria",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProdutosIds",
                table: "Receita");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Categoria");
        }
    }
}
