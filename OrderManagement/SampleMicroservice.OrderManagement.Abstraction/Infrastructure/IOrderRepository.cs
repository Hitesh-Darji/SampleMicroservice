using SampleMicroservice.OrderManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.OrderManagement.Abstraction.Infrastructure
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllAsync();
        Task<Order?> GetByIdAsync(int id);
        Task<Order?> CreateAsync(Order order);
    }
}
