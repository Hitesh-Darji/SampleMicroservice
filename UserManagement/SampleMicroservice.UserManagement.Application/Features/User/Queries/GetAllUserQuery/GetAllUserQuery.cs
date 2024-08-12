using MediatR;
using SampleMicroservice.UserManagement.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.UserManagement.Application.Features.User.Queries.GetAllUserQuery
{
    public class GetAllUserQuery : IRequest<IEnumerable<UserDto>>
    {
    }
}
