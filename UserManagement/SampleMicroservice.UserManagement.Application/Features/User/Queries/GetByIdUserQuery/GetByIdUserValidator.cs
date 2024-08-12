using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.UserManagement.Application.Features.User.Queries.GetByIdUserQuery
{
    public class GetByIdUserValidator : AbstractValidator<GetByIdUserQuery>
    {
        public GetByIdUserValidator()
        {
            RuleFor(x => x.UserId)
                .NotEqual(0);
        }
    }
}
