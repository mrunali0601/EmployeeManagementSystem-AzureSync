using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Application.Dtos.EmployeeDto;
using MediatR;

namespace EmployeeManagementSystem.Application.Features.EmployeeDetails.Command.UpdateEmployee
{
    public record UpdateEmployeeCommad(int empID,EmployeeDto employeeDto):IRequest<EmployeeDto>;
 
}
