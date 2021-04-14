using CleanArchitectureAPI.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitectureAPI.Queries
{
    public class GetEmployeeQueryValidator: AbstractValidator<GetEmployeeQuery>
    {
        public GetEmployeeQueryValidator()
        {
            RuleFor(x => x.Department).NotEmpty()
                .WithMessage("Department can not null");
        }
    }
}
