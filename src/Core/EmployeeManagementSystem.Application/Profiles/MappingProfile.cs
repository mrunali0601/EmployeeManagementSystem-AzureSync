using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagementSystem.Application.Dtos.EmployeeDto;
using EmployeeManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EmployeeManagementSystem.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }
    }
}
