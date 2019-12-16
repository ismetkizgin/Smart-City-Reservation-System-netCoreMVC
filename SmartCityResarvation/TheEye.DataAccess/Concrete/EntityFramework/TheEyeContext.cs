using Microsoft.EntityFrameworkCore;
using TheEye.Entities.Concrete;

namespace TheEye.DataAccess.Concrete.EntityFramework
{
    public class TheEyeContext : DbContext
    {
        public DbSet<CarPark> CarParks { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<PetrolStation> PetrolStations { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Ssn> Ssn { get; set; }
        public DbSet<Sss> Sss { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=.; Initial Catalog=TheEyeDB; Integrated Security=True;");
            }
        }
    }
}