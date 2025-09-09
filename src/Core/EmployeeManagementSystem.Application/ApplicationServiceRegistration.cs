using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Application.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagementSystem.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection service)
        {
            service.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
            //service.AddAutoMapper(typeof(MappingProfile).Assembly);
            return service;
        }
    }
}
