using EManagement_BusinessEngine.Contracts;
using EManagement_Common.VModels;
using EManagement_Data.Contracts;
using EManagement_Data.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace EManagement_.Controllers
{
    public class EmployeeLeaveTypesController : Controller
    {
        private readonly IEmployeeLeaveTypeBusinessEngine _employeeLeaveTypeBusinessEngine;
        public EmployeeLeaveTypesController(IEmployeeLeaveTypeBusinessEngine employeeLeaveTypeBusinessEngine)
        {
            _employeeLeaveTypeBusinessEngine = employeeLeaveTypeBusinessEngine;
        }
        public IActionResult Index()
        {
            var data = _employeeLeaveTypeBusinessEngine.GetAllEmployeeLeaveTypes();

            if(data.IsSuccess)
            {
                var result = data.Data;
                return View(result);
            }

            return View();
        }

		public IActionResult Create()
		{
			return View();
		}

        [HttpPost]
        public ActionResult Create(EmployeeLeaveTypeViewModel model)
        {
            if(ModelState.IsValid)
            {
                var data = _employeeLeaveTypeBusinessEngine.CreateEmployeeLeaveType(model);
                if(data.IsSuccess)
                {
					return RedirectToAction("Index");
				}return View(model);
            }
            else
            return View(model);
        }

        [HttpGet]
		public ActionResult Edit(int id)
		{
            if(id<0)
            {
                return View();
            }
            var data = _employeeLeaveTypeBusinessEngine.GetAllEmployeeLeaveType(id);
            if(data.IsSuccess)
				return View(data.Data);
			return View();
        }


        [ValidateAntiForgeryToken] //Post operation can not be made without making the get operation
        [HttpPost]
        public ActionResult Edit(EmployeeLeaveTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var data = _employeeLeaveTypeBusinessEngine.EditEmployeeLeaveType(model);
                if (data.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                return View(model);
            }
            else
                return View(model);
        }



        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return Json(new { success = false, message = "Select a record to delete." });
            
            var data=_employeeLeaveTypeBusinessEngine.RemoveEmployeeLeaveType(id);
            if(data.IsSuccess)
                return Json(new { success = data.IsSuccess, message = data.Message });
            else
                return Json(new { success = data.IsSuccess, message = data.Message });
        }
    }
}
