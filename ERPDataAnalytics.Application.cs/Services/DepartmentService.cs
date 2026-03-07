using ERPDataAnalytics.Application.cs.Interface;
using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using ERPDataAnalytics.domain.cs.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentInterface _DepartmentInterface;

        public DepartmentService(IDepartmentInterface DepartmentInterface)
        {
            _DepartmentInterface = DepartmentInterface;
        }

        public Task<ResponseDataModel<Department>> AddDepartment(Department model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Department>>> GetAllDepartment()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Department>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Department>> UpdateDepartment(int id, Department model)
        {
            throw new NotImplementedException();
        }
    }
}
