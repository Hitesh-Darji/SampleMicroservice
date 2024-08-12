using MediatR;
using SampleMicroservice.OrderManagement.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.OrderManagement.Application.Features.Order.Queries.GetAllOrderQuery
{
    public class GetAllOrderQuery : IRequest<IEnumerable<OrderDto>>
    {
    }
}
