using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleMicroservice.UserManagement.Application.Features.User.Queries.GetAllUserQuery;
using SampleMicroservice.UserManagement.Application.Features.User.Queries.GetByIdUserQuery;

namespace SampleMicroservice.UserManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<UserController> _logger;

        public UserController(IMediator mediator, ILogger<UserController> logger)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var user = await _mediator.Send(new GetAllUserQuery());
            return Ok(user);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetAsync([FromRoute] int userId)
        {
            var user = await _mediator.Send(new GetByIdUserQuery() { UserId = userId });
            return Ok(user);
        }
    }
}
