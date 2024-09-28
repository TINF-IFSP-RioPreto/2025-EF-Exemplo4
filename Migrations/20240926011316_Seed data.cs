using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF.Exemplo3.Migrations
{
    /// <inheritdoc />
    public partial class Seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "produto",
                columns: new[] { "ProdutoID", "ProdutoAtivo", "ProdutoEstoque", "ProdutoNome", "ProdutoPreco" },
                values: new object[] { 1, true, 10, "Bolacha", 4.76m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "ProdutoID",
                keyValue: 1);
        }
    }
}
