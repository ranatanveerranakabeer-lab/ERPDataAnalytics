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
    public class CustomerRepository : ICustomerInterface
    {
        private readonly DataContext _dataContext;
        public CustomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Customer> DeleteCustomer(int id)
        {
            var res = await _dataContext.Customers.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _dataContext.Customers.Remove(res);
                await _dataContext.SaveChangesAsync();
            }
            return null;
        }
        public async Task CreateCustomer(Customer model)
        {
            await _dataContext.Customers.AddAsync(model);
            await _dataContext.SaveChangesAsync();

        }
        public async Task<Customer> GetCustomerById(int id)
        {
            return await _dataContext.Customers.FindAsync(id);
        }

        public async Task<List<Customer>> GetCustomerList()
        {
            return await _dataContext.Customers.ToListAsync();
        }

        public async Task UpdateCustomer(Customer model)
        {
            var updatedata = await _dataContext.Customers.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.Balance = model.Balance;
                updatedata.BranchId = model.BranchId;
                updatedata.Address = model.Address;
                updatedata.CompanyId = model.CompanyId;
                updatedata.Phone = model.Phone;
                _dataContext.Customers.Update(updatedata);
                await _dataContext.SaveChangesAsync();





            }
        }
    }
}