using ERPDataAnalytics.domain.cs.Entities;
using ERPDataAnalytics.domain.cs.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Infrastructure.cs.Repository
{
   public class PayrollRepository : IPayrollInterface
    {
        private readonly DataContext _context;
        public PayrollRepository(DataContext context) { 
        
        _context = context;
        
        }

        public async Task<Payroll> DeletePayroll(int id)
        {
            var res = await _context.Payrolls.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Payrolls.Remove(res);
                await _context.SaveChangesAsync();
            }
            return null;
        }
        public async Task CreatePayroll(Payroll model)
        {
            await _context.Payrolls.AddAsync(model);
            await _context.SaveChangesAsync();

        }
        public async Task<Payroll> GetPayrollById(int id)
        {
            return await _context.Payrolls.FindAsync(id);
        }

        public async Task<List<Payroll>> GetPayrollList()
        {
            return await _context.Payrolls.ToListAsync();
        }

        public async Task UpdatePayroll(Payroll model)
        {
            var updatedata = await _context.Payrolls.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {
                updatedata.BasicSalary= model.BasicSalary;
                updatedata.PaymentDate= model.PaymentDate;
                updatedata.OvertimeAmount = model.OvertimeAmount;
                updatedata.NetSalary = model.NetSalary;
                _context.Payrolls.Update(updatedata);
                await _context.SaveChangesAsync();

            }
        }


    }
}
