using AutoMapper;
using MediatR;
using SampleMicroservice.UserManagement.Abstraction.Infrastructure;
using SampleMicroservice.UserManagement.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.UserManagement.Application.Features.User.Queries.GetAllUserQuery
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, IEnumerable<UserDto>>
    {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetAllUserQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<UserDto>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<IEnumerable<UserDto>>(await _userRepository.GetAllAsync());
        }
    }
}
