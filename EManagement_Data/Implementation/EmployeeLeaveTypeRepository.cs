using EManagement_Data.Contracts;
using EManagement_Data.DataContext;
using EManagement_Data.DbModels;

namespace EManagement_Data.Implementation
{
    public class EmployeeLeaveTypeRepository:Repository<EmployeeLeaveType>,IEmployeeLeaveTypeRepository
    {
        private readonly EManagement_Context _ctx;

        public EmployeeLeaveTypeRepository(EManagement_Context ctx) : base(ctx)
        {
            _ctx = ctx; 
        }
    }
}
