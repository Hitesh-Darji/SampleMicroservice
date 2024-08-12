using AutoMapper;
using SampleMicroservice.UserManagement.Application.Dto;
using SampleMicroservice.UserManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.UserManagement.Application.Mappings
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
