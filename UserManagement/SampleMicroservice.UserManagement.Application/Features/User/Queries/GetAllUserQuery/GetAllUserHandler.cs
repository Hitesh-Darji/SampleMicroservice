using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SampleMicroservice.UserManagement.Abstraction.Infrastructure;
using SampleMicroservice.UserManagement.Application.Dto;

namespace SampleMicroservice.UserManagement.Application.Features.User.Queries.GetAllUserQuery
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, IEnumerable<UserDto>>
    {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetAllUserQueryHandler> _logger;

        public GetAllUserQueryHandler(IUserRepository userRepository, IMapper mapper, ILogger<GetAllUserQueryHandler> logger)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<UserDto>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<IEnumerable<UserDto>>(await _userRepository.GetAllAsync());
        }
    }
}
