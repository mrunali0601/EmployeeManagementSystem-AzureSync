using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagementSystem.Application.Contracts.Persistence;
using EmployeeManagementSystem.Application.Dtos.EmployeeDto;
using MediatR;

namespace EmployeeManagementSystem.Application.Features.EmployeeDetails.Query.GetEmployeeById
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeDto>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeByIdQueryHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<EmployeeDto> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var content = await _employeeRepository.GetEmployeeByIdAsync(request.empId);
            if (content == null)
            {
                throw new Exception("Permission Not Found");
            }
            var getContents = _mapper.Map<EmployeeDto>(content);
            return getContents;
        }
    }
}
