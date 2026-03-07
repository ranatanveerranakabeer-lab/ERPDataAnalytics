using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Entities
{
    public class Branch
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string? BranchName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public bool IsActive { get; set; }
    }
}
