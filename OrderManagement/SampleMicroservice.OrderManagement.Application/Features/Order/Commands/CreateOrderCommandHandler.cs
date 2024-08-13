using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SampleMicroservice.OrderManagement.Abstraction.Infrastructure;
using SampleMicroservice.OrderManagement.Application.Dto;

namespace SampleMicroservice.OrderManagement.Application.Features.Order.Commands
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, OrderDto>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateOrderCommandHandler> _logger;

        public CreateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper, ILogger<CreateOrderCommandHandler> logger)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException( nameof(logger));
        }

        public async Task<OrderDto> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Domain.Entities.Order>(command);
            return _mapper.Map<OrderDto>(await _orderRepository.CreateAsync(order));
        }
    }
}
