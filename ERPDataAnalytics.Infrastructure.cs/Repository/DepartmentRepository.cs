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
    public class DepartmentRepository : IDepartmentInterface
    {
        private readonly DataContext _context;
        public DepartmentRepository(DataContext dataContext)
        {
            _context=dataContext;
        }

        public async Task<Department> DeleteDepartment(int id)
        {
            var res = await _context.Departments.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Departments.Remove(res);
                await _context.SaveChangesAsync();
            }
            return null;
        }
        public async Task CreateDepartment(Department model)
        {
            await _context.Departments.AddAsync(model);
            await _context.SaveChangesAsync();

        }
        public async Task<Department> GetDepartmentById(int id)
        {
            return await _context.Departments.FindAsync(id);
        }

        public async Task<List<Department>> GetDepartmentList()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task UpdateDepartment(Department model)
        {
            var updatedata = await _context.Departments.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.DepartmentName = model.DepartmentName;
                updatedata.CompanyId = model.CompanyId;
                updatedata.IsActive = model.IsActive;
                _context.Departments.Update(updatedata);
                await _context.SaveChangesAsync();

            }
        }



    }
}
