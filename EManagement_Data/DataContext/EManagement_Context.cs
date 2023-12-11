using EManagement_Data.DbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManagement_Data.DataContext
{
    public class EManagement_Context : IdentityDbContext
    {
        public EManagement_Context(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeLeaveAllocation> EmployeeLeaveAllocations { get; set; }
        public DbSet<EmployeeLeaveType> EmployeeLeaveTypes { get; set; }
        public DbSet<EmployeeLeaveRequest> EmployeeLeaveRequests { get; set; }

    }
}
