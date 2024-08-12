using Microsoft.EntityFrameworkCore;
using SampleMicroservice.OrderManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.OrderManagement.Infrastructure.Contexts
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
    }
}
