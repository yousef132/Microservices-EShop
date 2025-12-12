
namespace Ordering.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Add API services registrations here
            services.AddCarter();
            services.AddExceptionHandler<CustomExceptionHandler>();
            services.AddHealthChecks().AddSqlServer(configuration.GetConnectionString("Database"));
            return services;
        }

        public static WebApplication UseApiServices(this WebApplication app)
        {
            // Configure API middleware here
            app.MapCarter();
            app.UseExceptionHandler(opt => { });
            app.UseHealthChecks("/health",
           new HealthCheckOptions
           {
               ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
           });
            return app;
        }
    }
}
