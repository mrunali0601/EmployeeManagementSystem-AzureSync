using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Domain.Entities;
//using EmployeeManagementSystem.Persistence.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Persistence.Context
{
    public class EMSDbContext:IdentityDbContext<ApplicationUser>
    {
        public EMSDbContext(DbContextOptions<EMSDbContext> options):base(options)
        {
            
        }
        public DbSet<ApplicationUser>ApplicationUsers { get; set; }
        public DbSet<Employee>Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)

         {

            base.OnModelCreating(builder);

            //builder.ApplyConfiguration(new RoleSeedConfiguration());

            builder.ApplyConfiguration(new UserSeedConfiguration());

            //builder.ApplyConfiguration(new UserRoleSeedConfiguration());
           

        }

    }
}
