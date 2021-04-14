using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureAPI.Queries
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery,List<EmployeeListEntry>>
    {
        public async Task<List<EmployeeListEntry>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            return new List<EmployeeListEntry>
            {
                new EmployeeListEntry
                {
                    Department="IT",
                    Id=1,
                    Name="Information technology"
                }
            };
        }

        
    }
}
