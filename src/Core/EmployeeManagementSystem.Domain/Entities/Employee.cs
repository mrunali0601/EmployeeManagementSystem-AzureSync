using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Domain.Entities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId {  get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email {  get; set; }

        public string PhoneNo { get; set; }
        public string Designation {  get; set; }
        public string DepartmentName {  get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
