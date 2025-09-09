using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Application.Dtos.EmployeeDto
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; } 
        public string Name { get; set; } 
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Designation { get; set; }
        public string DepartmentName { get; set; }
    }
}
