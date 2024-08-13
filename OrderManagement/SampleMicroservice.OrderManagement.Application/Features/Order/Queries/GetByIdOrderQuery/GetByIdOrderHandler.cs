using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SampleMicroservice.OrderManagement.Abstraction.Infrastructure;
using SampleMicroservice.OrderManagement.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.OrderManagement.Application.Features.Order.Queries.GetByIdOrderQuery
{
    public class GetByIdOrderHandler : IRequestHandler<GetByIdOrderQuery, OrderDto>
    {

        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetByIdOrderHandler> _logger;

        public GetByIdOrderHandler(IOrderRepository orderRepository, IMapper mapper, ILogger<GetByIdOrderHandler> logger)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException( nameof(logger));
        }

        public async Task<OrderDto> Handle(GetByIdOrderQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<OrderDto>(await _orderRepository.GetByIdAsync(request.OrderId));
        }
    }
}
