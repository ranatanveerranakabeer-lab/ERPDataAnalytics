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
   public class ShiftRepository : IShiftInterface
    {
        private readonly DataContext _context;

        public ShiftRepository(DataContext context)
        {
            _context=context;   
        }

        public async Task<Shift> DeleteShift(int id)
        {
            var res = await _context.Shifts.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Shifts.Remove(res);
                await _context.SaveChangesAsync();
            }
            return null;
        }
        public async Task CreateShift(Shift model)
        {
            await _context.Shifts.AddAsync(model);
            await _context.SaveChangesAsync();

        }
        public async Task<Shift> GetShiftById(int id)
        {
            return await _context.Shifts.FindAsync(id);
        }

        public async Task<List<Shift>> GetShiftList()
        {
            return await _context.Shifts.ToListAsync();
        }

        public async Task UpdateShift(Shift model)
        {
            var updatedata = await _context.Shifts.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.StartTime = model.StartTime;
                updatedata.BranchId = model.BranchId;
                updatedata.Department = model.Department;
                updatedata.Designation = model.Designation;
                updatedata.CompanyId = model.CompanyId;
                updatedata.EndTime = model.EndTime;
                updatedata.CompanyId = model.CompanyId;
                updatedata.IsActive = model.IsActive;
                _context.Shifts.Update(updatedata);
                await _context.SaveChangesAsync();

            }
        }
    }
}
