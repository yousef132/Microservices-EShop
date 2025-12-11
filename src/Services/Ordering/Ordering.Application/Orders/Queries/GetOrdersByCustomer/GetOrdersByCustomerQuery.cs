namespace Ordering.Application.Orders.Queries.GetOrders
{
    public record GetOrdersByCustomerQuery(Guid CustomerId)
      : IQuery<GetOrdersByCustomerResult>;

    public record GetOrdersByCustomerResult(IEnumerable<OrderDto> Orders);


}
