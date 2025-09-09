using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagementSystem.Application.Contracts.Persistence;
using EmployeeManagementSystem.Application.Dtos.EmployeeDto;
using EmployeeManagementSystem.Domain.Entities;
using MediatR;

namespace EmployeeManagementSystem.Application.Features.EmployeeDetails.Command.AddEmployee
{
    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand, EmployeeDto>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public AddEmployeeCommandHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<EmployeeDto> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var result = new Employee();
            _mapper.Map(request.employeeDto, result);
            var addedRole = await _employeeRepository.AddEmployeeAsync(result);
            return request.employeeDto;
        }
    }
}
