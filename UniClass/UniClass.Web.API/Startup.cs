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

            //TODO Criar integração do swagger e injeção de dependências na aplicação
        }
    }
}
