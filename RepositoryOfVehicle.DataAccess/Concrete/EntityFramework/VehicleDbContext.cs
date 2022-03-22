using Microsoft.EntityFrameworkCore;
using RepositoryOfVehicle.Entities.Concrete;

namespace RepositoryOfVehicle.DataAccess.Concrete.EntityFramework
{
    public class VehicleDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;DataBase=RepositoryOfVehicle;Trusted_Connection=true");
        }

        public DbSet<Boat> Boats { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
