using CleanArchitecture.Application.Commands;
using CleanArchitecture.Application.Queries;
using CleanArchitecture.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController(ISender sender) : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> AddEmployee([FromBody] EmployeeEntity employee)
        {
            var result = await sender.Send(new AddEmplyeeCommand(employee));
            return Ok();
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var result = await sender.Send(new GetAllEmployeesQuery());
            return Ok(result);
        }
        [HttpGet("{employeeId}")]
        public async Task<IActionResult> GetAllEmployeeById([FromRoute] Guid employeeId)
        {
            var result = await sender.Send(new GetAllEmployeesByIdQuery(employeeId));
            return Ok(result);
        }
        [HttpPut("{employeeId}")]
        public async Task<IActionResult> UpdateEmployee([FromRoute] Guid employeeId, [FromBody] EmployeeEntity employee)
        {
            var result = await sender.Send(new UpdateEmployeeCommand(employeeId, employee));
            return Ok(result);
        }
        [HttpDelete("{employeeId}")]
        public async Task<IActionResult> UpdateEmployee([FromRoute] Guid employeeId)
        {
            var result = await sender.Send(new DeleteEmployeeCommand(employeeId));
            return Ok(result);
        }
    }
}
