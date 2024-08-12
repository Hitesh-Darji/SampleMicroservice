using FluentValidation;
namespace SampleMicroservice.OrderManagement.Application.Features.Order.Commands
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderValidator()
        {

            RuleFor(x => x.OrderNumber).NotNull();

            RuleFor(x=>x.Total).NotNull();
        }

    }
}
