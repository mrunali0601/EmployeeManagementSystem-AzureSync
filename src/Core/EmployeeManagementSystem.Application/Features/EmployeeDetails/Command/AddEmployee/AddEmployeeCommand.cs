using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Application.Dtos.EmployeeDto;
using MediatR;

namespace EmployeeManagementSystem.Application.Features.EmployeeDetails.Command.AddEmployee
{
    public record AddEmployeeCommand(EmployeeDto employeeDto):IRequest<EmployeeDto>;
   
}
