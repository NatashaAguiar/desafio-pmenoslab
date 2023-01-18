using desafio_pmenoslab.Models;
using Microsoft.EntityFrameworkCore;

namespace desafio_pmenoslab
{
    public class Context : DbContext 
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
