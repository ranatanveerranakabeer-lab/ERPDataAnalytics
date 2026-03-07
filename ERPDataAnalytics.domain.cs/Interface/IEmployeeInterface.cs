using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
    public interface IEmployeeInterface
    {
        Task<List<Employee>> GetEmployeeList();

        Task<Employee> GetEmployeeById(int id);


        Task CreateEmployee(Employee model);


        Task<Employee> DeleteEmployee(int id);

        Task UpdateEmployee(Employee model);
    }
}
