using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagementSystem.Application.Contracts.Persistence;
using MediatR;

namespace EmployeeManagementSystem.Application.Features.EmployeeDetails.Command.DeleteEmployee
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public DeleteEmployeeCommandHandler(IMapper mapper,IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        { 
            var getContent = await _employeeRepository.GetEmployeeByIdAsync(request.empID);
            if (getContent != null)
            {
                var result = await _employeeRepository.DeleteEmployeeAsync(getContent);
                return result;
            }
            return false;
        }
    }
}
