using MassTransit;
using Microsoft.Extensions.Logging;
using SampleMicroservice.Messaging.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.UserManagement.Application.Features.Test
{
    //public class OrderConsumer : IConsumer<OrderMessage>
    //{
    //    private readonly ILogger<OrderConsumer> _logger;
    //    public OrderConsumer(ILogger<OrderConsumer> logger)
    //    {
    //        _logger = logger;
    //    }
    //    public Task Consume(ConsumeContext<OrderMessage> context)
    //    {
    //        _logger.LogInformation($" [*] Message received Id: {context.Message.Id}, OrderNumber: {context.Message.OrderNumber} ,Total: {context.Message.Total} ");
    //        return Task.CompletedTask;
    //    }
    //}

}
