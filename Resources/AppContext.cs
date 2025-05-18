using Microsoft.EntityFrameworkCore;
using WindowsForm_Padaria.Model;

namespace WindowsForm_Padaria.Resources
{
    public class AppDbContext : DbContext
    {
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Estoque_Prod_Fornecedor> Estoque_Prod_Fornecedor { get; set; }
        public DbSet<Estoque_Prod_Padaria> Estoque_Prod_Padaria { get; set; }
        public DbSet<Fornecedor_Produto> Fornecedor_Produto { get; set; }
        public DbSet<Padaria_Prod_Receita> Padaria_Prod_Receita {  get; set; }
        public DbSet<Padaria_Produto> Padaria_Produto { get; set; }
        public DbSet<Produto_Receita> Produto_Receita { get; set; }
        public DbSet<Receita> Receita {  get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<Venda_Produto> Venda_Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "server=localhost;database=Padaria_WindowsForm;user=root;password=11Fg06@**@";
                optionsBuilder.UseMySql(
                    connectionString,
                    ServerVersion.AutoDetect(connectionString) 
                );
            }
        }
    }
}