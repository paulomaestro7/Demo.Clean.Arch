using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace Demo.Clean.Arch.Repository
{
    //public class Program
    //{
    //    public static void Main(string[] args)
    //        => CreateHostBuilder(args).Build().Run();

    //    public static IHostBuilder CreateHostBuilder(string[] args)
    //       => Host.CreateDefaultBuilder(args)
    //           .ConfigureWebHostDefaults(
    //               webBuilder => webBuilder.UseStartup<Startup>());
    //}
    //public class Startup
    //{
    //    public void ConfigureServices(IServiceCollection services)
    //        => services.Repository();
    //}

    public class DemoContextFactory : Microsoft.EntityFrameworkCore.Design.IDesignTimeDbContextFactory<DemoContext>
    {
        public DemoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DemoContext>();
            optionsBuilder.UseNpgsql("Data Source=blog.db");

            return new DemoContext(optionsBuilder.Options);
        }
    }
}
