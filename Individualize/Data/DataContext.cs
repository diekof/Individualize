using Microsoft.EntityFrameworkCore;
using Individualize.Models;

namespace Individualize.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Condominio> Condominios { get; set; }
        public DbSet<Medicao> Medicoes { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

    }
}
