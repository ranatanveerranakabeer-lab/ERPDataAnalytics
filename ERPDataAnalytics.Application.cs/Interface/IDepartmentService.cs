using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
   public interface IDepartmentService
    {
        Task<ResponseDataModel<List<Department>>> GetAllDepartment();

        Task<ResponseDataModel<Department>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteDepartment(int id);

        Task<ResponseDataModel<Department>> UpdateDepartment(int id, Department model);


        Task<ResponseDataModel<Department>> AddDepartment(Department model);
    }
}
