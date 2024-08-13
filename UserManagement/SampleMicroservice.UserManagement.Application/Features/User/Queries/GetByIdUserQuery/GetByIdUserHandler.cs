using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SampleMicroservice.UserManagement.Abstraction.Infrastructure;
using SampleMicroservice.UserManagement.Application.Dto;

namespace SampleMicroservice.UserManagement.Application.Features.User.Queries.GetByIdUserQuery
{
    public class GetByIdUserHandler : IRequestHandler<GetByIdUserQuery, UserDto>
    {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetByIdUserHandler> _logger;

        public GetByIdUserHandler(IUserRepository userRepository, IMapper mapper, ILogger<GetByIdUserHandler> logger)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<UserDto> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<UserDto>(await _userRepository.GetByIdAsync(request.UserId));
        }
    }
}
