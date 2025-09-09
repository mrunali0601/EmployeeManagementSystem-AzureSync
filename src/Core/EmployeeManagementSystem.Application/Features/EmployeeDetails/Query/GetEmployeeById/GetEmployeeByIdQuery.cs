using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Application.Dtos.EmployeeDto;
using MediatR;

namespace EmployeeManagementSystem.Application.Features.EmployeeDetails.Query.GetEmployeeById
{
    public record GetEmployeeByIdQuery(int empId):IRequest<EmployeeDto>; 
}
