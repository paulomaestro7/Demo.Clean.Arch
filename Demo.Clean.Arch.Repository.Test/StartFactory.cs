using Microsoft.Extensions.DependencyInjection;
using System;

namespace Demo.Clean.Arch.Repository.Test
{
    public class StartFactory
    {
        public void Start(ref IServiceProvider service)
        {
            var services = new ServiceCollection();
            services.Repository();
            service = services.BuildServiceProvider();
        }
    }
}
