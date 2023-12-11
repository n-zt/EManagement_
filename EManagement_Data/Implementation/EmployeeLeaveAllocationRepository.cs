using EManagement_Data.Contracts;
using EManagement_Data.DataContext;
using EManagement_Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManagement_Data.Implementation
{
    public class EmployeeLeaveAllocationRepository:Repository<EmployeeLeaveAllocation>,IEmployeeLeaveAllocationRepository
    {
        private readonly EManagement_Context _ctx;
        public EmployeeLeaveAllocationRepository(EManagement_Context ctx) :base(ctx)
        {
            _ctx = ctx;
        }
     
    }
}
