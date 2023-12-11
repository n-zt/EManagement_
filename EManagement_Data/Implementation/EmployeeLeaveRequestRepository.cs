using EManagement_Data.Contracts;
using EManagement_Data.DataContext;
using EManagement_Data.DbModels;

namespace EManagement_Data.Implementation
{
    public class EmployeeLeaveRequestRepository:Repository<EmployeeLeaveRequest>,IEmployeeLeaveRequestRepository
    {
        private readonly EManagement_Context _ctx;

        public EmployeeLeaveRequestRepository(EManagement_Context ctx) : base(ctx)
        {
            _ctx = ctx; 
        }
    }
}
