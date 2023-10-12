

using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace cars.models
{
    public class CarContext : DbContext
    {
        public CarContext()
        {

        }
        public CarContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost; database=Cars; user=root; password=", ServerVersion.AutoDetect("server=localhost; database=Cars; user=root; password="));
            }
        }
        public DbSet<Car> Cars { get; set; } = null;
    }
}
