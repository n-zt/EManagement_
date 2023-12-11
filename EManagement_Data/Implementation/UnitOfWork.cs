using EManagement_Data.Contracts;
using EManagement_Data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManagement_Data.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EManagement_Context _ctx;

        public UnitOfWork(EManagement_Context ctx)
        {
            _ctx = ctx;
            EmployeeLeaveAllocationRepository = new EmployeeLeaveAllocationRepository(_ctx);
            EmployeeLeaveRequestRepository = new EmployeeLeaveRequestRepository(_ctx);
            EmployeeLeaveTypeRepository = new EmployeeLeaveTypeRepository(_ctx);
        }
        public IEmployeeLeaveAllocationRepository EmployeeLeaveAllocationRepository { get; private set; }
        public IEmployeeLeaveRequestRepository EmployeeLeaveRequestRepository { get; private set; }
        public IEmployeeLeaveTypeRepository EmployeeLeaveTypeRepository { get; private set; }

        public void Dispose()
        {
            _ctx.Dispose();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }
    }
}
