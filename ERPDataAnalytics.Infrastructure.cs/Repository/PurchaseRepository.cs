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
    public class PurchaseRepository : IPurchaseInterface
    {

private readonly DataContext _dataContext;

        public PurchaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext; 
        }

        public async Task<Purchase> DeletePurchase(int id)
        {
            var res = await _dataContext.Purchases.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _dataContext.Purchases.Remove(res);
                await _dataContext.SaveChangesAsync();
            }
            return null;
        }
        public async Task CreatePurchase(Purchase model)
        {
            await _dataContext.Purchases.AddAsync(model);
            await _dataContext.SaveChangesAsync();

        }
        public async Task<Purchase> GetPurchaseById(int id)
        {
            return await _dataContext.Purchases.FindAsync(id);
        }

        public async Task<List<Purchase>> GetPurchaseList()
        {
            return await _dataContext.Purchases.ToListAsync();
        }

        public async Task UpdatePurchase(Purchase model)
        {
            var updatedata = await _dataContext.Purchases.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.BranchId = model.BranchId;
                updatedata.InvoiceNumber = model.InvoiceNumber;
                updatedata.PurchaseDate = model.PurchaseDate;
                updatedata.VendorId = model.VendorId;
                updatedata.CompanyId = model.CompanyId;


                _dataContext.Purchases.Update(updatedata);
                await _dataContext.SaveChangesAsync();

            }

        }
    }
}
