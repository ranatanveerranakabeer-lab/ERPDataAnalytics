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
    public class SaleRepository : ISaleInterface
    {
        private readonly DataContext _dataContext;
        public SaleRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Sale> DeleteSale(int id)
        {
            var res = await _dataContext.Sales.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _dataContext.Sales.Remove(res);
                await _dataContext.SaveChangesAsync();
            }
            return null;
        }
        public async Task CreateSale(Sale model)
        {
            await _dataContext.Sales.AddAsync(model);
            await _dataContext.SaveChangesAsync();

        }
        public async Task<Sale> GetSaleById(int id)
        {
            return await _dataContext.Sales.FindAsync(id);
        }

        public async Task<List<Sale>> GetSaleList()
        {
            return await _dataContext.Sales.ToListAsync();
        }

        public async Task UpdateSale(Sale model)
        {
            var updatedata = await _dataContext.Sales.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.SaleDate = model.SaleDate;
                updatedata.InvoiceNumber = model.InvoiceNumber;
                updatedata.BranchId = model.BranchId;
                updatedata.CustomerId = model.CustomerId;
                updatedata.CompanyId = model.CompanyId;
                updatedata.DiscountAmount = model.DiscountAmount;
                updatedata.NetAmount = model.NetAmount;
                updatedata.TotalAmount = model.TotalAmount;

                _dataContext.Sales.Update(updatedata);
                await _dataContext.SaveChangesAsync();

            }
        }
    }
}