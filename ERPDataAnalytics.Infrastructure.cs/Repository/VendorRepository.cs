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
   public class VendorRepository : IVendorInterface
    {
        private readonly DataContext _dataContext;
        public VendorRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task CreateVendor(Vendor model)
        {
            await _dataContext.Vendors.AddAsync(model);
            await _dataContext.SaveChangesAsync();

        }

        public async Task<Vendor> DeleteVendor(int id)
        {
            var res = await _dataContext.Vendors.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _dataContext.Vendors.Remove(res);
                await _dataContext.SaveChangesAsync();
            }
            return null;
        }

        public async Task<Vendor> GetVendorById(int id)
        {
            return await _dataContext.Vendors.FindAsync(id);
        }

        public async Task<List<Vendor>> GetVendorList()
        {
            return await _dataContext.Vendors.ToListAsync();
        }

        public async Task UpdateVendor(Vendor model)
        {
            var updatedata = await _dataContext.Vendors.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.Address = model.Address;
                updatedata.CompanyId = model.CompanyId;
                updatedata.Phone = model.Phone;
                updatedata.Balance = model.Balance;
                updatedata.Name = model.Name;
                _dataContext.Vendors.Update(updatedata);
                await _dataContext.SaveChangesAsync();



           

            }
        }


    }
}
