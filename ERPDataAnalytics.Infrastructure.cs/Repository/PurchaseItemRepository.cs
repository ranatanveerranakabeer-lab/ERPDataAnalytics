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
    public class PurchaseItemRepository : IPurchaseItemInterface
    {
        private readonly DataContext _dataContext;
        public PurchaseItemRepository(DataContext dataContext)
        {
             _dataContext = dataContext;    
        }
        public async Task<PurchaseItem> DeletePurchaseItem(int id)
        {
            var res = await _dataContext.PurchaseItems.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _dataContext.PurchaseItems.Remove(res);
                await _dataContext.SaveChangesAsync();
            }
            return null;
        }
        public async Task CreatePurchaseItem(PurchaseItem model)
        {
            await _dataContext.PurchaseItems.AddAsync(model);
            await _dataContext.SaveChangesAsync();

        }
        public async Task<PurchaseItem> GetPurchaseItemById(int id)
        {
            return await _dataContext.PurchaseItems.FindAsync(id);
        }

        public async Task<List<PurchaseItem>> GetPurchaseItemList()
        {
            return await _dataContext.PurchaseItems.ToListAsync();
        }

        public async Task UpdatePurchaseItem(PurchaseItem model)
        {
            var updatedata = await _dataContext.PurchaseItems.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.PurchaseId = model.PurchaseId;
                updatedata.ProductId = model.ProductId;
                updatedata.Quantity = model.Quantity;
                updatedata.UnitCost = model.UnitCost;
               
               
                             _dataContext.PurchaseItems.Update(updatedata);
                await _dataContext.SaveChangesAsync();

            }
        }
    }
}
