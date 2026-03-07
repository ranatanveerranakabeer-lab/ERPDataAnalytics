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
    public class DesignationRepository : IDesignationInterface
    {
        private readonly DataContext _dataContext;
        public DesignationRepository(DataContext dataContext)
        {
            _dataContext = dataContext; 
        }

        public async Task<Designation> DeleteDesignation(int id)
        {
            var res = await _dataContext.Designations.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _dataContext.Designations.Remove(res);
                await _dataContext.SaveChangesAsync();
            }
            return null;
        }
        public async Task CreateDesignation(Designation model)
        {
            await _dataContext.Designations.AddAsync(model);
            await _dataContext.SaveChangesAsync();

        }
        public async Task<Designation> GetDesignationById(int id)
        {
            return await _dataContext.Designations.FindAsync(id);
        }

        public async Task<List<Designation>> GetDesignationList()
        {
            return await _dataContext.Designations.ToListAsync();
        }

        public async Task UpdateDesignation(Designation model)
        {
            var updatedata = await _dataContext.Designations.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.DepartmentId = model.DepartmentId;
                updatedata.CompanyId = model.CompanyId;
                updatedata.IsActive = model.IsActive;
                _dataContext.Designations.Update(updatedata);
                await _dataContext.SaveChangesAsync();

            }
        }


    }
}
