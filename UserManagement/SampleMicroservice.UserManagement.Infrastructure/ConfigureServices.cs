using Microsoft.Extensions.DependencyInjection;
using SampleMicroservice.UserManagement.Abstraction.Infrastructure;
using SampleMicroservice.UserManagement.Infrastructure.Repositories;
using SampleMicroservice.UserManagement.Infrastructure.Seeder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.UserManagement.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInjectionPersistence(this IServiceCollection services)
        {
            services.AddScoped<UserDbSeeder>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
