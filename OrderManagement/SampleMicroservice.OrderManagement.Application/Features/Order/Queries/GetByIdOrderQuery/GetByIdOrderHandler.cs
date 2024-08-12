using AutoMapper;
using MediatR;
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

        public GetByIdOrderHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<OrderDto> Handle(GetByIdOrderQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<OrderDto>(await _orderRepository.GetByIdAsync(request.OrderId));
        }
    }
}
