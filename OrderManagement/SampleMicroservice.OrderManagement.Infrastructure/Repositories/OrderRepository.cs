using Microsoft.EntityFrameworkCore;
using SampleMicroservice.OrderManagement.Abstraction.Infrastructure;
using SampleMicroservice.OrderManagement.Domain.Entities;
using SampleMicroservice.OrderManagement.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.OrderManagement.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDbContext _orderDbContext;
        public OrderRepository(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;
        }
        public async Task<Order?> CreateAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _orderDbContext.Orders.ToListAsync();
        }

        public async Task<Order?> GetByIdAsync(int id)
        {
            return await _orderDbContext.Orders.FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
