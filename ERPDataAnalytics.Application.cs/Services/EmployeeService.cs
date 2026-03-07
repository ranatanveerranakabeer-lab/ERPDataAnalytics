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
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeInterface _Employeerepo;

        public EmployeeService(IEmployeeInterface EmployeeInterface)
        {
            _Employeerepo = EmployeeInterface;
        }

        public Task<ResponseDataModel<Employee>> AddEmployee(Employee model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Employee>>> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Employee>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Employee>> UpdateEmployee(int id, Employee model)
        {
            throw new NotImplementedException();
        }
    }
}
