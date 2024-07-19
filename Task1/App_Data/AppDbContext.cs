using Microsoft.EntityFrameworkCore;
using Task1.Models;

namespace Task1.App_Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HPCK2O7;Database=Capital;Trusted_Connection=true;TrustServerCertificate=true;");
        }
    }
}
