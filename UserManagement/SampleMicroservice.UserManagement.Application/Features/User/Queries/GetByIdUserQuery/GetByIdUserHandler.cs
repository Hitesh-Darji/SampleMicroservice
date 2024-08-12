using AutoMapper;
using MediatR;
using SampleMicroservice.UserManagement.Abstraction.Infrastructure;
using SampleMicroservice.UserManagement.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.UserManagement.Application.Features.User.Queries.GetByIdUserQuery
{
    public class GetByIdUserHandler : IRequestHandler<GetByIdUserQuery, UserDto>
    {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetByIdUserHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<UserDto> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<UserDto>(await _userRepository.GetByIdAsync(request.UserId));
        }
    }
}
