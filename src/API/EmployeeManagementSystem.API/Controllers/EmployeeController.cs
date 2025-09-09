using EmployeeManagementSystem.Application.Dtos.EmployeeDto;
using EmployeeManagementSystem.Application.Features.EmployeeDetails.Command.AddEmployee;
using EmployeeManagementSystem.Application.Features.EmployeeDetails.Command.DeleteEmployee;
using EmployeeManagementSystem.Application.Features.EmployeeDetails.Command.UpdateEmployee;
using EmployeeManagementSystem.Application.Features.EmployeeDetails.Query.GetAllEmployees;
using EmployeeManagementSystem.Application.Features.EmployeeDetails.Query.GetEmployeeById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator  _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetAllEmployee")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var res= await _mediator.Send(new GetAllEmployeeQuery());
            return Ok(res);
        }
        [HttpGet("GetEmployeeById")]
        public async Task<IActionResult>GetEmployeeById(int empId)
        {
            var res = await _mediator.Send(new GetEmployeeByIdQuery(empId));
            return Ok(res);
        }
        [HttpPost("AddEmployee")]
        public async Task<IActionResult>AddEmployee(EmployeeDto employeeDto)
        {
            var res=await _mediator.Send(new AddEmployeeCommand(employeeDto));
            return Ok(res);
        }
        [HttpPut("UpdateEmployee")]
        public async Task<IActionResult>UpdateEmployee( int empId,EmployeeDto employeeDto)
        {
            var res=await _mediator.Send(new UpdateEmployeeCommad(empId, employeeDto));
            return Ok(res);
        }
        [HttpDelete("DeleteEmployee")]
        public async Task<IActionResult>DeleteEmployee(int empId)
        {
            var res=await _mediator.Send(new DeleteEmployeeCommand(empId));
            return Ok(res);
        }
    }
}
