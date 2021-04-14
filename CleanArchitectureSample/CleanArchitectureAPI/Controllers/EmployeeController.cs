using CleanArchitectureAPI.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitectureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediatr;
        public EmployeeController(IMediator mediator)
        {
            _mediatr = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployees([FromQuery] GetEmployeeQuery query)
        {
            return Ok(await _mediatr.Send(query));
        }
    }
}
