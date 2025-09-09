using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Application.Contracts.Persistence;
using EmployeeManagementSystem.Persistence.Context;
using EmployeeManagementSystem.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagementSystem.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddInterfaceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IEmployeeRepository,  EmployeeRepository>();
            services.AddDbContext<EMSDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("EmployeeManagementDbConnString")).ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning)); ;
            });
            return services;
        }
    }

}
