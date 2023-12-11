using EManagement_Common.ResultModels;
using EManagement_Common.VModels;
using System.Collections.Generic;


namespace EManagement_BusinessEngine.Contracts
{
    public interface IEmployeeLeaveTypeBusinessEngine
    {
        Result<List<EmployeeLeaveTypeViewModel>> GetAllEmployeeLeaveTypes();
		//Result<List<WorkOrderVM>> GetWorkOrderByEmployeeId(string employeeId, EnumWorkOrderStatus workOrderStatus);

		/// <summary>
		/// New Employe Leave Type Create Method
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		Result<EmployeeLeaveTypeViewModel> CreateEmployeeLeaveType(EmployeeLeaveTypeViewModel model);


		/// <summary>
		/// Employee Leave Type by Id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		Result<EmployeeLeaveTypeViewModel> GetAllEmployeeLeaveType( int id);

        Result<EmployeeLeaveTypeViewModel> EditEmployeeLeaveType(EmployeeLeaveTypeViewModel model);

        Result<EmployeeLeaveTypeViewModel> RemoveEmployeeLeaveType(int id);
    }
}
