using Microsoft.EntityFrameworkCore;
using TheEye.Entities.Concrete;

namespace TheEye.DataAccess.Concrete.EntityFramwork
{
    public class TheEyeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.; Initial Catalog=TheEye; Integrated Security=True;");
        }
        public DbSet<User> Users { get; set; }
    }
}