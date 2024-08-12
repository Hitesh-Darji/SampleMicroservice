using Microsoft.Extensions.DependencyInjection;
using SampleMicroservice.OrderManagement.Abstraction.Infrastructure;
using SampleMicroservice.OrderManagement.Infrastructure.Repositories;
using SampleMicroservice.OrderManagement.Infrastructure.Seeder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.OrderManagement.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInjectionPersistence(this IServiceCollection services)
        {
            services.AddScoped<OrderDbSeeder>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            return services;
        }
    }
}
