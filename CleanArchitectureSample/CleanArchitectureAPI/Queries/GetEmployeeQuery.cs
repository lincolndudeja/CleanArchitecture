using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitectureAPI.Queries
{
    public class GetEmployeeQuery: IRequest<List<EmployeeListEntry>>
    {
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
