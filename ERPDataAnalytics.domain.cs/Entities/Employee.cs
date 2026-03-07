using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string CNIC { get; set; }
        public decimal BasicSalary { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool IsActive { get; set; }
    }
}
