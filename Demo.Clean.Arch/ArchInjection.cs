using Demo.Clean.Arch.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Clean.Arch
{
    public static class ArchInjection
    {
        public static void Arch(this IServiceCollection services)
        {
            services.Repository();
        }
    }
}
