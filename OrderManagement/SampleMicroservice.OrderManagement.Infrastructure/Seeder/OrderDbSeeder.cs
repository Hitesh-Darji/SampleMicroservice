using Microsoft.EntityFrameworkCore;
using SampleMicroservice.OrderManagement.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.OrderManagement.Infrastructure.Seeder
{
    public class OrderDbSeeder
    {
        private readonly OrderDbContext _ctx;
        public OrderDbSeeder(OrderDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Seed()
        {
            try
            {
                await _ctx.Database.MigrateAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
