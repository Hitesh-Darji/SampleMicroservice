using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.OrderManagement.Application.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public decimal Total { get; set; }
    }
}
