namespace Service
{
    public class Startup
    {
        IConfiguration Configuration { get; }
        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            ; //DO NOT REMOVE THIS

            Configuration = builder.Build();
        }
        public ServiceProvider InitialiseServices()
        {
            IServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            return services.BuildServiceProvider();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();
            services.AddEnyimMemcached(Configuration);

        }
    }
}