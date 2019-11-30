using Microsoft.EntityFrameworkCore;
using ProjetoP.WebApi.Model;

namespace ProjetoP.WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Jogo> Jogo { get; set; }
        
    }
}