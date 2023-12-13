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
    public class EmployeeRepository:Repository<Employee>,IEmployeeRepository
    {
        private readonly EManagement_Context _ctx;

        public EmployeeRepository(EManagement_Context ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
