using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
    public interface IEmployeeService
    {
        Task<ResponseDataModel<List<Employee>>> GetAllEmployee();

        Task<ResponseDataModel<Employee>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteEmployee(int id);

        Task<ResponseDataModel<Employee>> UpdateEmployee(int id, Employee model);


        Task<ResponseDataModel<Employee>> AddEmployee(Employee model);
    }
}
