using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.OrderManagement.Domain.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public decimal Total { get; set; }
    }
}
