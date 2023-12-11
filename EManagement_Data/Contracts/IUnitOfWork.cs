using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManagement_Data.Contracts
{
    public interface IUnitOfWork:IDisposable
    {
        IEmployeeLeaveAllocationRepository EmployeeLeaveAllocationRepository { get; }
        IEmployeeLeaveRequestRepository EmployeeLeaveRequestRepository { get; }
        IEmployeeLeaveTypeRepository EmployeeLeaveTypeRepository { get; }
        void Save();
    }
}
