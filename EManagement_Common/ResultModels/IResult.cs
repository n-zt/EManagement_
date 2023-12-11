using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManagement_Common.ResultModels
{
    public interface IResult
    {
        bool IsSuccess { get; set; }
        string Message { get; set; }
    }
}
