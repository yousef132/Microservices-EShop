using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.Messaging.MassTransit
{
    public static class Extentions
    {
        public static IServiceCollection AddMessageBroker(this IServiceCollection services)
        {
            // MassTransit configuration can be added here in the future
            return services;
        }
    }
}
