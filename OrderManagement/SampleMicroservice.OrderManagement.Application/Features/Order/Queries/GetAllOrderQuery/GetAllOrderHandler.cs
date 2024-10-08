﻿using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SampleMicroservice.OrderManagement.Abstraction.Infrastructure;
using SampleMicroservice.OrderManagement.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.OrderManagement.Application.Features.Order.Queries.GetAllOrderQuery
{
    public class GetAllOrderHandler : IRequestHandler<GetAllOrderQuery, IEnumerable<OrderDto>>
    {

        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetAllOrderHandler> _logger;

        public GetAllOrderHandler(IOrderRepository orderRepository, IMapper mapper, ILogger<GetAllOrderHandler> logger)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger=logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<OrderDto>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<IEnumerable<OrderDto>>(await _orderRepository.GetAllAsync());
        }
    }
}
