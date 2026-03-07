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
    public class BranchRepository : IBranchInterface
    {
        private readonly DataContext _context;
        public BranchRepository(DataContext context)
        {
            _context = context;
        }
        public async Task CreateBranch(Branch model)
        {
            await _context.Branches.AddAsync(model);
            await _context.SaveChangesAsync();

        }

        public async Task<Branch> DeleteBranch(int id)
        {
            var res = await _context.Branches.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Branches.Remove(res);
                await _context.SaveChangesAsync();
            }
            return null;
        }

        public async Task<Branch> GetBranchById(int id)
        {
            return await _context.Branches.FindAsync(id);
        }

        public async Task<List<Branch>> GetBranchList()
        {
            return await _context.Branches.ToListAsync();
        }

        public async Task UpdateBranch(Branch model)
        {
            var updatedata = await _context.Branches.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.BranchName = model.BranchName;
                updatedata.Address = model.BranchName;
                updatedata.Phone = model.Phone;
                updatedata.CompanyId = model.CompanyId;

                _context.Branches.Update(updatedata);
                await _context.SaveChangesAsync();





            }
        }
    }
}