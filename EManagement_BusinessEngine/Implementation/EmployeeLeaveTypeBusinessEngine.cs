using AutoMapper;
using EManagement_BusinessEngine.Contracts;
using EManagement_Common.ConstantsModels;
using EManagement_Common.ResultModels;
using EManagement_Common.VModels;
using EManagement_Data.Contracts;
using EManagement_Data.DbModels; 
using EManagement_Data.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManagement_BusinessEngine.Implementation
{
    public class EmployeeLeaveTypeBusinessEngine: IEmployeeLeaveTypeBusinessEngine
    {
        private readonly IUnitOfWork _unitofWork;
        private readonly IMapper _mapper;

        public EmployeeLeaveTypeBusinessEngine(IUnitOfWork unitofWork, IMapper mapper)
        {
            _unitofWork=unitofWork;
            _mapper = mapper;
        }

		public Result<List<EmployeeLeaveTypeViewModel>> GetAllEmployeeLeaveTypes()
        {
            var data = _unitofWork.EmployeeLeaveTypeRepository.GetAll(x=>x.IsActive==true).ToList();
            //#region 1.Yontem
            //if (data != null)
            //{
            //    List<EmployeeLeaveType> returnData = new List<EmployeeLeaveType>();
            //    foreach (var item in data)
            //    {
            //        returnData.Add(new EmployeeLeaveType()
            //        {
            //            Id = item.Id,
            //            DateCreated = item.DateCreated,
            //            DefaultDays = item.DefaultDays,
            //            Name = item.Name
            //        });
            //    }
            //    return new Result<List<EmployeeLeaveType>>(true, ResultConstant.RecordFound, returnData);
            //}
            //else
            //    return new Result<List<EmployeeLeaveType>>(false, ResultConstant.RecordNotFound);
            //#endregion

            #region 2.Yontem
            var leaveTypes = _mapper.Map<List<EmployeeLeaveType>, List<EmployeeLeaveTypeViewModel>>(data);
            return new Result<List<EmployeeLeaveTypeViewModel>>(true, ResultConstants.RecordFound, leaveTypes);
			#endregion
			
		}


        
		public Result<EmployeeLeaveTypeViewModel> CreateEmployeeLeaveType(EmployeeLeaveTypeViewModel model)
		{
			if (model != null)
			{
				try
				{
					var leaveType = _mapper.Map<EmployeeLeaveTypeViewModel, EmployeeLeaveType>(model);
					leaveType.DateCreated = DateTime.Now;
                    leaveType.IsActive= true;
					_unitofWork.EmployeeLeaveTypeRepository.Add(leaveType);
					_unitofWork.Save();
					return new Result<EmployeeLeaveTypeViewModel>(true, ResultConstants.RecordCreatedSuccessfully);
				}
				catch (Exception ex)
				{
					return new Result<EmployeeLeaveTypeViewModel>(false, ResultConstants.RecordCreatedNotSuccessfully + "=>" + ex.Message.ToString());
				}
			}
			else
				return new Result<EmployeeLeaveTypeViewModel>(false, "Data Passed as Parameter Cannot Be Empty!");

		}

		public Result<EmployeeLeaveTypeViewModel> GetAllEmployeeLeaveType(int id)
		{
            var data = _unitofWork.EmployeeLeaveTypeRepository.Get(id);
            if(data!=null)
            {
				var leaveType = _mapper.Map<EmployeeLeaveType,EmployeeLeaveTypeViewModel>(data);
				return new Result<EmployeeLeaveTypeViewModel>(true, ResultConstants.RecordFound, leaveType);
			}
			else
				return new Result<EmployeeLeaveTypeViewModel>(false, ResultConstants.RecordNotFound);
		}

        public Result<EmployeeLeaveTypeViewModel> EditEmployeeLeaveType(EmployeeLeaveTypeViewModel model)
        {
            if (model != null)
            {
                try
                {
                    var leaveType = _mapper.Map<EmployeeLeaveTypeViewModel, EmployeeLeaveType>(model);
                    leaveType.DateCreated = DateTime.Now;
                    _unitofWork.EmployeeLeaveTypeRepository.Update(leaveType);
                    _unitofWork.Save();
                    return new Result<EmployeeLeaveTypeViewModel>(true, ResultConstants.RecordCreatedSuccessfully);
                }
                catch (Exception ex)
                {
                    return new Result<EmployeeLeaveTypeViewModel>(false, ResultConstants.RecordCreatedNotSuccessfully + "=>" + ex.Message.ToString());
                }
            }
            else
                return new Result<EmployeeLeaveTypeViewModel>(false, "Data Passed as Parameter Cannot Be Empty!");

        }

        public Result<EmployeeLeaveTypeViewModel> RemoveEmployeeLeaveType(int id)
        {
            var data = _unitofWork.EmployeeLeaveTypeRepository.Get(id);
            if (data != null)
            {
                data.IsActive = false;
                _unitofWork.EmployeeLeaveTypeRepository.Update(data);
                _unitofWork.Save();
                return new Result<EmployeeLeaveTypeViewModel>(true, ResultConstants.RecordRemovedSuccessfully);
            }
            else
                return new Result<EmployeeLeaveTypeViewModel>(false, ResultConstants.RecordRemovedNotSuccessfully);
        }
    }
}
