using BuildingBlocks.Behaviors;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Application
{
    public static class DepenedencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Add application services registrations here
            services.AddMediatR(cfg =>
            {
                cfg.AddOpenBehavior(typeof(ValidationBehavior<,>));
                cfg.AddOpenBehavior(typeof(LoggingBehavior<,>));
                cfg.RegisterServicesFromAssembly(typeof(DepenedencyInjection).Assembly);
            });
            return services;
        }
    }

}
