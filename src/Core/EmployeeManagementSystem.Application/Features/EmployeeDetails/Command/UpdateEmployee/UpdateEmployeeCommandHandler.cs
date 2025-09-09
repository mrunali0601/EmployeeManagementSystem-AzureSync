using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagementSystem.Application.Contracts.Persistence;
using EmployeeManagementSystem.Application.Dtos.EmployeeDto;
using MediatR;

namespace EmployeeManagementSystem.Application.Features.EmployeeDetails.Command.UpdateEmployee
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommad, EmployeeDto>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public UpdateEmployeeCommandHandler(IMapper mapper,IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
             _mapper = mapper;
        }
        public async Task<EmployeeDto> Handle(UpdateEmployeeCommad request, CancellationToken cancellationToken)
        {

            var updatedContent = await _employeeRepository.GetEmployeeByIdAsync(request.empID);
            if (updatedContent == null)
            {
                throw new Exception("Employee Not Found");
            }
            _mapper.Map(request.employeeDto, updatedContent);
            var result = await _employeeRepository.UpdateEmployeeAsync(updatedContent);
            return request.employeeDto;
        }
    }
}
