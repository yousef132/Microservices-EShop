using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Application
{
    public static class DepenedencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Add application services registrations here
            return services;
        }
    }
}
