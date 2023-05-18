using Microsoft.EntityFrameworkCore;

using UniClass.Domain.Configuration;
using UniClass.Infra.Data;
using UniClass.Infra.Extensions;

namespace UniClass.Web.API.Extensions
{
    public static class DBContexteExtensions
    {
        public static void AddUniClassDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var appSettings = configuration.LoadSettings<AppSettings>("AppSettings", services);
            services.AddDbContext<UniClassDBContext>(opt => opt.UseSqlServer(appSettings.ConnectionString));
        }

        //TODO Criar método para realizar as migrações e criar as tabelas no SQLServer
    }
}
