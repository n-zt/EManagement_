using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManagement_Data.DbModels
{
    public class EmployeeLeaveAllocation:BaseEntity
    {

        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }


        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public string EmployeeId { get; set; }


        [ForeignKey("EmployeeLeaveTypeId")]
        public EmployeeLeaveType EmployeeLeaveType { get; set; }
        public int EmployeeLeaveTypeId { get; set; }


        public int Period { get; set; }
    }
}
