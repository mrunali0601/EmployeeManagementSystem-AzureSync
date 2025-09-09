using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Application.Contracts.Persistence;
using EmployeeManagementSystem.Domain.Entities;
using EmployeeManagementSystem.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeManagementSystem.Persistence.Repository
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly EMSDbContext _emsDbContext;
        public EmployeeRepository(EMSDbContext emsDbContext)
        {
            _emsDbContext = emsDbContext;
        }

        public async Task<Employee> AddEmployeeAsync(Employee emp)
        { 
            await _emsDbContext.Employees.AddAsync(emp);
            await _emsDbContext.SaveChangesAsync();
            return emp;
        }

        public async Task<bool> DeleteEmployeeAsync( Employee employee)
        { 
           employee.IsDeleted= true;
            _emsDbContext.Employees.Update(employee);
            await _emsDbContext.SaveChangesAsync();
            return true; 
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            var res = await _emsDbContext.Employees.Where(e=>e.IsDeleted==false).ToListAsync();
            return res;
        }

            public async Task<Employee> GetEmployeeByIdAsync(int empId)
            {
                 var res= await _emsDbContext.Employees.FirstOrDefaultAsync(b=>b.EmployeeId == empId);
                return res;
            }

        public async Task<Employee> UpdateEmployeeAsync(Employee emp)
        {
            var res =  _emsDbContext.Update(emp);
            await _emsDbContext.SaveChangesAsync();
            return emp;

        }
    }
}
