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
    public class SaleItemRepository : ISaleItemInterface
    {
        private readonly DataContext _context;

        public SaleItemRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public async Task<SaleItem> DeleteSaleItem(int id)
        {
            var res = await _context.SaleItems.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.SaleItems.Remove(res);
                await _context.SaveChangesAsync();
            }
            return null;
        }
        public async Task CreateSaleItem(SaleItem model)
        {
            await _context.SaleItems.AddAsync(model);
            await _context.SaveChangesAsync();

        }
        public async Task<SaleItem> GetSaleItemById(int id)
        {
            return await _context.SaleItems.FindAsync(id);
        }

        public async Task<List<SaleItem>> GetSaleItemList()
        {
            return await _context.SaleItems.ToListAsync();
        }

        public async Task UpdateSaleItem(SaleItem model)
        {
            var updatedata = await _context.SaleItems.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.ProductId = model.ProductId;
                updatedata.SaleId = model.SaleId;
                updatedata.Quantity = model.Quantity;
                updatedata.UnitPrice = model.UnitPrice;
                updatedata.Total = model.Total;


                _context.SaleItems.Update(updatedata);
                await _context.SaveChangesAsync();

            }



        }
    }
}