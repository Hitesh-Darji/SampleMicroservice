using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.OrderManagement.Application.Features.Order.Queries.GetByIdOrderQuery
{
    public class GetByIdOrderValidator : AbstractValidator<GetByIdOrderQuery>
    {
        public GetByIdOrderValidator()
        {
            RuleFor(x => x.OrderId)
                .NotEqual(0);
        }
    }
}
