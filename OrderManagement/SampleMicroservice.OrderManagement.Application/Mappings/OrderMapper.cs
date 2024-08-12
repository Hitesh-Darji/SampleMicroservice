using AutoMapper;
using SampleMicroservice.Messaging.Contracts;
using SampleMicroservice.OrderManagement.Application.Dto;
using SampleMicroservice.OrderManagement.Application.Features.Order.Commands;
using SampleMicroservice.OrderManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SampleMicroservice.OrderManagement.Application.Mappings
{
    public class OrderMapper : Profile
    {
        public OrderMapper()
        {
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Order, CreateOrderCommand>().ReverseMap();
            CreateMap<Order, OrderMessage>().ReverseMap();
            CreateMap<OrderDto, OrderMessage>().ReverseMap();
        }
    }
}
