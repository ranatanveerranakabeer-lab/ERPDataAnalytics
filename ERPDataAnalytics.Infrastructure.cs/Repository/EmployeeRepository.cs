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
   public class EmployeeRepository : IEmployeeInterface
    {
        private readonly DataContext _dataContext;
        public EmployeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Employee> DeleteEmployee(int id)
        {
            var res = await _dataContext.Employees.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _dataContext.Employees.Remove(res);
                await _dataContext.SaveChangesAsync();
            }
            return null;
        }
        public async Task CreateEmployee(Employee model)
        {
            await _dataContext.Employees.AddAsync(model);
            await _dataContext.SaveChangesAsync();

        }
        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _dataContext.Employees.FindAsync(id);
        }

        public async Task<List<Employee>> GetEmployeeList()
        {
            return await _dataContext.Employees.ToListAsync();
        }

        public async Task UpdateEmployee(Employee model)
        {
            var updatedata = await _dataContext.Employees.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.CNIC = model.CNIC;
                updatedata.BasicSalary = model.BasicSalary;
                updatedata.FullName = model.FullName;
                _dataContext.Employees.Update(updatedata);
                await _dataContext.SaveChangesAsync();

            }
        }


    }
}
