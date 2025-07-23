using Microsoft.EntityFrameworkCore;
using LagerverwaltungApp.Models;

namespace LagerverwaltungApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Artikel> Artikel { get; set; }

        // Konstruktor nimmt DbContextOptions entgegen
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
