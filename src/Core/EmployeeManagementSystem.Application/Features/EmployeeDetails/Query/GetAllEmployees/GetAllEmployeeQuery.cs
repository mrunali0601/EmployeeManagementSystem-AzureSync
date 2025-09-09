using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Application.Dtos.EmployeeDto;
using EmployeeManagementSystem.Domain.Entities;
using MediatR;

namespace EmployeeManagementSystem.Application.Features.EmployeeDetails.Query.GetAllEmployees
{
    public record GetAllEmployeeQuery:IRequest<IEnumerable<EmployeeDto>>;
     
}
