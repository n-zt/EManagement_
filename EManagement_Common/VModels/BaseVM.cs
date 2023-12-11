using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManagement_Common.VModels
{
    public class BaseVM
    {
        [Key]
        public int id { get; set; }
    }
}
