using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Infrastructure
{
    public static class DepenedencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("Database") ?? 
                throw new InvalidOperationException("Connection string 'OrderingConnectionString' not found.");
            // Add application services registrations here
            return services;
        }

    }
}
