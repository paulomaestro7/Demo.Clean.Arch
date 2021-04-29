using Demo.Clean.Arch.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo.Clean.Arch.Repository
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options) { }
        public DbSet<PersonModel> Person { get; set; }
        public DbSet<UserLevelModel> UserLevel { get; set; }
        public DbSet<UserModel> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                        "User ID =postgres;Password=Demo2021!;Server=localhost;Port=15432;Database=Demo;Pooling=true;"
                        );
        }
    }
}
