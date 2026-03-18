using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int EmployeeId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string?   PasswordHash { get; set; } // encrypted hu ga
        public int  RoleId { get; set; }
        public bool IsActive { get; set; }
    }
}
