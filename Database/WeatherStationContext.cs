using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class WeatherStationContext : DbContext
    {
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<User> Users { get; set; }
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("<CONNECTION STRING>");
        }
    }
}