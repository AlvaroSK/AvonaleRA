using AvonaleRA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AvonaleRA.Context
{
    public class AppDbContext : DbContext 
    {
        public DbSet<Produto> Produtos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));
        }
    }
}
