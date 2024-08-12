using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleMicroservice.OrderManagement.Application.Features.Order.Queries.GetAllOrderQuery;
using SampleMicroservice.OrderManagement.Application.Features.Order.Queries.GetByIdOrderQuery;

namespace SampleMicroservice.OrderManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var user = await _mediator.Send(new GetAllOrderQuery());
            return Ok(user);
        }

        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetAsync([FromRoute] int orderId)
        {
            var user = await _mediator.Send(new GetByIdOrderQuery() { OrderId = orderId });
            return Ok(user);
        }
    }
}
