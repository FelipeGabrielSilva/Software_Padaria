using Microsoft.EntityFrameworkCore;
using WindowsForm_Padaria.Model;

namespace WindowsForm_Padaria.Resources
{
    public class AppDbContext : DbContext
    {
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Estoque_Prod_Fornecedor> Estoque_Prod_Fornecedor { get; set; }
        public DbSet<Estoque_Prod_Padaria> Estoque_Prod_Padaria { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Fornecedor_Produto> Fornecedor_Produto { get; set; }
        public DbSet<Padaria_Prod_Receita> Padaria_Prod_Receita {  get; set; }
        public DbSet<Padaria_Produto> Padaria_Produto { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
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
            };
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estoque_Prod_Fornecedor>().Property(e => e.Tipo).HasConversion<string>();
            modelBuilder.Entity<Estoque_Prod_Padaria>().Property(e => e.Tipo).HasConversion<string>();
            modelBuilder.Entity<Venda>().Property(e=> e.Status).HasConversion<string>();
            modelBuilder.Entity<Padaria_Produto>().Property(e => e.Preco).HasColumnType("decimal(9,2)");
            modelBuilder.Entity<Venda_Produto>().Property(e => e.PrecoUnitario).HasColumnType("decimal(9,2)");
            modelBuilder.Entity<Venda>().Property(e => e.Preco).HasColumnType("decimal(9,2)");

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasIndex(f => f.CNPJ).IsUnique();

                entity.HasOne(f => f.Pagamento)
                .WithMany()
                .HasForeignKey(f => f.PagamentoId)
                .IsRequired();
            });

            modelBuilder.Entity<Fornecedor_Produto>(entity => 
            {
                entity.HasIndex(f => f.Codigo).IsUnique();
            });

            modelBuilder.Entity<Padaria_Produto>(entity =>
            {
                entity.HasIndex(f => f.Codigo).IsUnique();
            });

            modelBuilder.Entity<Venda_Produto>(entity =>
            {
                entity.HasKey(f => new { f.VendaId, f.ProdutoId });

                entity.HasOne(f => f.Venda)
                .WithMany(v => v.VendaProdutos)
                .HasForeignKey(v => v.VendaId);

                entity.HasOne(f => f.Produto)
                .WithMany()
                .HasForeignKey(v => v.ProdutoId);
            });

            modelBuilder.Entity<Padaria_Prod_Receita>(entity =>
            {
                entity.HasKey(f => new { f.ReceitaId, f.ProdutoId });
            });
        }
    }
}