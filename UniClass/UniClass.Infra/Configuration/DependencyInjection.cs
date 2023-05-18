using Microsoft.Extensions.DependencyInjection;
using UniClass.Infra.Data;

namespace UniClass.Infra.Configuration
{
    public static class DependencyInjection
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<UniClassDBContext>();
        }
    }
}
