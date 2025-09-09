using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Domain.Entities;

namespace EmployeeManagementSystem.Application.Contracts.Persistence
{
    public interface IEmployeeRepository
    {
        Task<Employee> AddEmployeeAsync(Employee emp);
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee> UpdateEmployeeAsync(Employee emp);
        Task<Employee> GetEmployeeByIdAsync(int empId);
        Task<bool> DeleteEmployeeAsync(Employee employee);
    }
}
