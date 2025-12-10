using Ordering.Domain.Abstractions;
using Ordering.Domain.Enums;
using Ordering.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Domain.Models
{

    //Aggregate root : Order
    //Entity : OrderItem
    //Value Object : Address, Money
    public class Order : Aggregate<Guid>
    {
        private readonly List<OrderItem> _orderItems = new();
        public IReadOnlyList<OrderItem> OrderItems => _orderItems.AsReadOnly();

        public Guid CustomerId { get; private set; } = default!;
        public string OrderName { get; private set; } = default!;

        public Address ShippingAddress { get; private set; } = default!;
        public Address BillingAddress { get; private set; } = default!;
        public Payment Payment { get; private set; } = default!;
        public OrderStatus Status { get; private set; } = OrderStatus.Pending;
        public decimal TotalAmount 
        { 
            get 
            {
                return _orderItems.Sum(item => item.Quantity * item.Price);
            }
            private set { }
        }
    }
    public class Product : Entity<Guid>
    {
        public string Name { get; private set; } = default!;
        public decimal Price { get; private set; } =default!;
    }
}
