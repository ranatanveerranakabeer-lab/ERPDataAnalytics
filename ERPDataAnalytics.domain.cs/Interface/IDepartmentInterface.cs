using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
   public interface IDepartmentInterface
    {
        Task<List<Department>> GetDepartmentList();

        Task<Department> GetDepartmentById(int id);


        Task CreateDepartment(Department model);


        Task<Department> DeleteDepartment(int id);

        Task UpdateDepartment(Department model);
    }
}
