using AutoMapper;
using EManagement_Common.VModels;
using EManagement_Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManagement_Common.Mappings
{
    public class Maps:Profile
    {
        public Maps()
        {
            CreateMap<EmployeeLeaveType, EmployeeLeaveTypeViewModel>().ReverseMap();
            CreateMap<EmployeeLeaveAllocation, EmployeeLeaveAllocationViewModel>().ReverseMap();
            CreateMap<EmployeeLeaveRequest, EmployeeLeaveRequestViewModel>().ReverseMap();
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
        }
    }
}
