using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagementSystem.Application.Contracts.Persistence;
using EmployeeManagementSystem.Application.Dtos.EmployeeDto;
using MediatR;

namespace EmployeeManagementSystem.Application.Features.EmployeeDetails.Query.GetAllEmployees
{
    public class GetAllEmployeeQueryHandler : IRequestHandler<GetAllEmployeeQuery, IEnumerable<EmployeeDto>>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public GetAllEmployeeQueryHandler(IMapper mapper,IEmployeeRepository employeeRepository )
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<EmployeeDto>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            var content = await _employeeRepository.GetAllEmployeesAsync();
            if (content == null)
            {
                throw new Exception("Content Not Found");
            }
            var allcontents = _mapper.Map<IEnumerable<EmployeeDto>>(content);
            return allcontents;
            

        }
    }
}
