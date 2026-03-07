using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Entities
{
    public class Payroll
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Month { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal OvertimeAmount { get; set; }
        public decimal DeductionAmount { get; set; }
        public decimal BonusAmount { get; set; }
        public decimal NetSalary { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
    }
}
