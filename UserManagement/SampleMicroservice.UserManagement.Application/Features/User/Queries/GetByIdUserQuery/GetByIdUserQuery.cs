using MediatR;
using SampleMicroservice.UserManagement.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.UserManagement.Application.Features.User.Queries.GetByIdUserQuery
{
    public class GetByIdUserQuery : IRequest<UserDto>
    {
        public int UserId { get; set; }
    }
}
