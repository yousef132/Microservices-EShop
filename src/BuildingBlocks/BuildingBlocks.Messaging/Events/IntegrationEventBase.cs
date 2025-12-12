namespace BuildingBlocks.Messaging.Events
{
    // base class for integration events
    public record IntegrationEventBase
    {
        Guid EventId => Guid.NewGuid();
        public DateTime OccurredOn => DateTime.Now;
        public string EventType => GetType().AssemblyQualifiedName;
    }
}
