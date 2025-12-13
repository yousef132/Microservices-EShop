
using Microsoft.FeatureManagement;

namespace Ordering.Application.Orders.EventHandlers.Domain
{
    public class OrderCreatedDomainEventHandler(ILogger<OrderCreatedDomainEventHandler> logger,
                                                IPublishEndpoint publisher,
                                                IFeatureManager featureManager)
        : INotificationHandler<OrderCreatedEvent>
    {
        public async Task Handle(OrderCreatedEvent domainEvent, CancellationToken cancellationToken)
        {
            logger.LogInformation("Domain Event handled: {DomainEvent}", domainEvent.GetType().Name);

            if (await featureManager.IsEnabledAsync("OrderFullfilment"))
            {
                // create the integration event
                var orderCreatedIntegrationEvent = domainEvent.order.ToOrderDto();
                // publish it 
                await publisher.Publish(orderCreatedIntegrationEvent, cancellationToken);
            }


        }
    }
}
