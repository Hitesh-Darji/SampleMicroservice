using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<OrderRepository> _logger;
        public OrderRepository(OrderDbContext orderDbContext, ILogger<OrderRepository> logger)
        {
            _orderDbContext = orderDbContext ?? throw new ArgumentNullException(nameof(Order));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<Order?> CreateAsync(Order order)
        {
            _orderDbContext.Orders.Add(order);
            await _orderDbContext.SaveChangesAsync();
            return order;
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
