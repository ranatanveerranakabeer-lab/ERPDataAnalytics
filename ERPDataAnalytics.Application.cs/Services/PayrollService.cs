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
    public class PayrollService : IPayrollService
    {
        private readonly IPayrollInterface _Payrollrepository;

        public PayrollService(IPayrollInterface PayrollInterface)
        {
            _Payrollrepository = PayrollInterface;
        }

        public Task<ResponseDataModel<Payroll>> AddPayroll(Payroll model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeletePayroll(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Payroll>>> GetAllPayroll()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Payroll>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Payroll>> UpdatePayroll(int id, Payroll model)
        {
            throw new NotImplementedException();
        }
    }
}
