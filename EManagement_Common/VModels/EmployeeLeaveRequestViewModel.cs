using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManagement_Common.VModels
{
    public class EmployeeLeaveRequestViewModel : BaseVM
    {
        public string RequestingEmployeeId { get; set; }
        public EmployeeViewModel RequestingEmployee { get; set; }



        //Onaylayan Kullanıcı Bilgileri
        public string ApprovedEmployeeId { get; set; }
        public EmployeeViewModel ApprovedEmployee { get; set; }



        public int EmployeeLeaveTypeId { get; set; }
        public EmployeeLeaveTypeViewModel EmployeeLeaveType { get; set; }


        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }

        [Display(Name = "Talep")]   

        [MaxLength(300,ErrorMessage ="300'den fazla karakter girilemez.")]
        public string RequestComments { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
