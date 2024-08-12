using MediatR;
using SampleMicroservice.OrderManagement.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.OrderManagement.Application.Features.Order.Queries.GetByIdOrderQuery
{
    public class GetByIdOrderQuery : IRequest<OrderDto>
    {
        public int OrderId { get; set; }
    }
}
