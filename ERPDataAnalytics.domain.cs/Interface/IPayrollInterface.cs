using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
   public interface IPayrollInterface
    {
        Task<List<Payroll>> GetPayrollList();

        Task<Payroll> GetPayrollById(int id);


        Task CreatePayroll(Payroll model);


        Task<Payroll> DeletePayroll(int id);

        Task UpdatePayroll(Payroll model);
    }
}
