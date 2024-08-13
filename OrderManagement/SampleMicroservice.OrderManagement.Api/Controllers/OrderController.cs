using AutoMapper;
using MassTransit;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleMicroservice.Messaging.Contracts;
using SampleMicroservice.OrderManagement.Application.Dto;
using SampleMicroservice.OrderManagement.Application.Features.Order.Commands;
using SampleMicroservice.OrderManagement.Application.Features.Order.Queries.GetAllOrderQuery;
using SampleMicroservice.OrderManagement.Application.Features.Order.Queries.GetByIdOrderQuery;

namespace SampleMicroservice.OrderManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IPublishEndpoint _publish;
        private readonly IMapper _mapper;
        private readonly ILogger<OrderController> _logger;

        public OrderController(IMediator mediator, IPublishEndpoint publish, IMapper mapper, ILogger<OrderController> logger)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _publish = publish ?? throw new ArgumentNullException(nameof(publish));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentException(nameof(logger));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var orders = await _mediator.Send(new GetAllOrderQuery());
            return Ok(orders);
        }

        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetAsync([FromRoute] int orderId)
        {
            var user = await _mediator.Send(new GetByIdOrderQuery() { OrderId = orderId });
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CreateOrderCommand order)
        {
            var orderDto = await _mediator.Send(order);
            await _publish.Publish<OrderMessage>(_mapper.Map<OrderMessage>(orderDto));
            return Ok(order);
        }

    }
}
