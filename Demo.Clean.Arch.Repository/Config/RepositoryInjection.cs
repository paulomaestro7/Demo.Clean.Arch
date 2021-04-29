using Demo.Clean.Arch.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Clean.Arch.Repository
{
    public static class RepositoryInjection
    {
        public static void Repository(this IServiceCollection services)
        {
            services.AddEntityFrameworkNpgsql()
                    .AddDbContext<DemoContext>(opt => opt.UseNpgsql(
                        "User ID =postgres;Password=Demo2021!;Server=localhost;Port=15432;Database=Demo;Pooling=true;"
                        ));

            services.AddTransient<IUserLevelRepository, UserLevelRepository>();
        }
    }
}
