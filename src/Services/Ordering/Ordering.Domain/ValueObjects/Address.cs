
namespace Ordering.Domain.ValueObjects
{
    // record is suitable for value objects, because it is immutable 
    public record Address
    {
        public string FirstName { get; } = default!;
        public string LastName { get; } = default!;
        public string? EmailAddress { get; } = default!;
        public string AddressLine{ get; } = default!;
        public string Country { get; } = default!;
        public string State { get; } = default!;
        public string ZipCode{ get; } = default!;

    }
}
