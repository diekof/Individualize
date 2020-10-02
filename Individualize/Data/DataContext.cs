using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
