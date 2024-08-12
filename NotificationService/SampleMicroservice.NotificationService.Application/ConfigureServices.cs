using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.NotificationService.Application
{
    public static class ConfigureServices
    {
        public static void AddInjectionApplication(this IServiceCollection services)
        {
            services.AddMassTransit(m =>
            {
                m.AddConsumers(Assembly.GetExecutingAssembly());
                m.UsingRabbitMq((ctx, cfg) =>
                {
                    cfg.Host("rabbitmq", "/", c =>
                    {
                        c.Username("guest");
                        c.Password("guest");
                    });
                    cfg.ConfigureEndpoints(ctx);
                });
            });

        }
    }
}
