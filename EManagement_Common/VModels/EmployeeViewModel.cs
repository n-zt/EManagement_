using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManagement_Common.VModels
{
    public class EmployeeViewModel
    {
        public string id { get; set; }

        [Display(Name ="Kullanıcı Adı")]
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
