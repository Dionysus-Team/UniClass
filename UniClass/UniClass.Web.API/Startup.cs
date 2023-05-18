using UniClass.Infra.Configuration;
using UniClass.Web.API.Extensions;

namespace UniClass.Web.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwagger();
            services.AddUniClassDbContext(Configuration);
            services.AddDependencies();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.ConfigSwagger();
            app.UseRouting();
            app.UseEndpoints(endpoints => 
            { 
                endpoints.MapControllers(); 
            });
        }
    }
}