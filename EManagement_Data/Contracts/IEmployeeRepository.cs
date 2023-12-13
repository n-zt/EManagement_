using EManagement_Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManagement_Data.Contracts
{
    public interface IEmployeeRepository:IRepositoryBase<Employee>
    {
    }
}
