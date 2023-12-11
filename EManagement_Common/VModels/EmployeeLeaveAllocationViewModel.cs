using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManagement_Common.VModels
{
    public class EmployeeLeaveAllocationViewModel:BaseVM
    {
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }


       
        public EmployeeViewModel EmployeeViewmodel { get; set; }
        public string EmployeeId { get; set; }


        public EmployeeLeaveTypeViewModel EmployeeLeaveTypeViewmodel { get; set; }
        public int EmployeeLeaveTypeId { get; set; }


        public int Period { get; set; }
    }
}
