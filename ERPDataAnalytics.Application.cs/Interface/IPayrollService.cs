using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
   public interface IPayrollService
    {
        Task<ResponseDataModel<List<Payroll>>> GetAllPayroll();

        Task<ResponseDataModel<Payroll>> GetById(int id);

        Task<ResponseDataModel<bool>> DeletePayroll(int id);

        Task<ResponseDataModel<Payroll>> UpdatePayroll(int id, Payroll model);


        Task<ResponseDataModel<Payroll>> AddPayroll(Payroll model);
    }
}
