using AvonaleRA.Models;
using Microsoft.EntityFrameworkCore;

namespace AvonaleRA.Context
{
    public class AppDbContext : DbContext 
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\\mssqllocaldb;Database=AvonaleRA;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
