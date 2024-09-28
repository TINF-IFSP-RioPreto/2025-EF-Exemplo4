using Microsoft.EntityFrameworkCore;

namespace EF.Exemplo3;

public class EstoqueDbContext : DbContext
{
    public DbSet<Produto> produto { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        // Isso não é bom! Não faça!!!
        // Crie um usuário específico para a aplicação, que tenha permissão
        // para criar o banco e operar nele
        optionsBuilder.UseNpgsql(@"Host=10.140.67.124;"+
                                 "Username=postgres;"+
                                 "Password=123456;"+
                                 "Database=exemplo3;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        ModelBuilderExtensions.SeedDatabase(modelBuilder);
    }
}

public static class ModelBuilderExtensions
{
    public static void SeedDatabase(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>().HasData (new Produto
            {
                ProdutoID = 1,
                ProdutoNome = "Bolacha",
                ProdutoPreco = 4.76m,
                ProdutoEstoque = 10,
                ProdutoAtivo = true
            }
        );
    }
}