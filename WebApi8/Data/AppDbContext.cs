using Microsoft.EntityFrameworkCore;
using WebApi8.Models;

namespace WebApi8.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        // Criação da tabela autores na database com o modelo de AutorModel
        public DbSet<AutorModel> Autores { get; set; }

        // Criação da tabela livros na database com o modelo de LivroModel
        public DbSet<LivroModel> Livros { get; set; }
    }
}
