
using SampleMicroservice.OrderManagement.Application.Dto;
using MediatR;

namespace SampleMicroservice.OrderManagement.Application.Features.Order.Commands
{
    public class CreateOrderCommand : IRequest<OrderDto>
    {
        public string OrderNumber { get; set; } = string.Empty;
        public decimal Total { get; set; }
        public CreateOrderCommand(string orderNumber, decimal total)
        {
            OrderNumber = orderNumber;
            Total = total;

        }
    }
}
