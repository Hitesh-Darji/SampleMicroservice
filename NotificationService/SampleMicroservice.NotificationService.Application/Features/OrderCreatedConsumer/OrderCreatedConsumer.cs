using MassTransit;
using Microsoft.Extensions.Logging;
using SampleMicroservice.Messaging.Contracts;

namespace SampleMicroservice.NotificationService.Application.Features.OrderCreatedConsumer
{
    public class OrderCreatedConsumer : IConsumer<OrderMessage>
    {
        //private readonly IEmailService _emailService;
        private readonly ILogger<OrderCreatedConsumer> _logger;
        public OrderCreatedConsumer(ILogger<OrderCreatedConsumer> logger/*, IEmailService emailService*/)
        {
            _logger = logger;
            //_emailService = emailService;
        }
        public Task Consume(ConsumeContext<OrderMessage> context)
        {
            _logger.LogInformation($" [*] Message received Id: {context.Message.Id}, OrderNumber: {context.Message.OrderNumber} ,Total: {context.Message.Total} ");

            //Format the body of the email for the notification
            //_emailService.SendEmail(toEmail, subject, messageBody);
            return Task.CompletedTask;
        }
    }
}
