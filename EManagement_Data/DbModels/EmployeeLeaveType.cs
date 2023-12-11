using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManagement_Data.DbModels
{
    public class EmployeeLeaveType:BaseEntity
    {

        [Required]
        public string Name { get; set; }

        public int DefaultDays { get; set; }

        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
    }
}
