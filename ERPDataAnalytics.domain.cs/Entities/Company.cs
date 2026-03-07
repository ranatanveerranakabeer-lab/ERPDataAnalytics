using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Entities
{
   public class Company
    {
        
            public int Id { get; set; }
            public string? CompanyName { get; set; }
            public string? Email { get; set; }
            public string? Phone { get; set; }
            public string?    Address { get; set; }
            public string? TaxNumber { get; set; }
            public bool IsActive { get; set; }
        }
    }
