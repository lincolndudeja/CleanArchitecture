using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureAPI.Behaviours
{
    public class ValidationBehaviour<TRequest, TResponse> : MediatR.IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> validator;
        public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validator)
        {
            this.validator = validator;
        }
        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var context = new ValidationContext<TRequest>(request);
            var errors = validator
                .Select(x => x.Validate(context))
                .SelectMany(x => x.Errors)
                .ToList();
            if (!errors.Any())
                return next();
            throw new Exception();
        }
    }
}
