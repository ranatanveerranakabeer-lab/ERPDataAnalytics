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

        public async Task<Sale> CreateSale(Sale model)
        {
           await _dataContext.AddAsync(model);
            await _dataContext.SaveChangesAsync();
            return model;
        }

        public async Task<bool> DeleteSale(int id)
        {
          var res=  await _dataContext.Sales.Where(X => X.Id == id).FirstOrDefaultAsync();
            if(res==null)
                return false;
            _dataContext.Sales.Remove(res);
            await _dataContext.SaveChangesAsync();
            return true;
        }

        public async Task<Sale> GetSaleById(int id)
        {
          return await _dataContext.Sales.Include(x=>x.SaleItemId).FirstOrDefaultAsync(x=>x.Id==id); 
        }

        public async Task<List<Sale>> GetSaleList()
        {
           var res= await _dataContext.Sales.Include(x=>x.SaleItemId).ToListAsync(); 
            return res;
        }

        public async Task<Sale> UpdateSale(Sale model)
        {
           var existingsale= await _dataContext.Sales.Include(x => x.SaleItemId).FirstOrDefaultAsync(x => x.Id == model.Id);
            if (existingsale == null)
                return null;
           existingsale.BranchId=model.BranchId;
            existingsale.CompanyId=model.CompanyId;
            existingsale.InvoiceNumber=model.InvoiceNumber;
            existingsale.CustomerId=model.CustomerId;
            existingsale.DiscountAmount=model.DiscountAmount;
            existingsale.NetAmount=model.NetAmount;
            existingsale.PaidAmount=model.PaidAmount;
            existingsale.TotalAmount=model.TotalAmount;
            existingsale.SaleDate=model.SaleDate;

            _dataContext.SaleItems.RemoveRange(existingsale.SaleItems);
            existingsale.SaleItems = new List<SaleItem>();
            foreach (var item in existingsale.SaleItems)
            {
                var saleitemlist = new SaleItem
                {
                    ProductId = item.ProductId,
                    UnitPrice = item.UnitPrice,
                    Quantity = item.Quantity,
                    Total = item.Quantity * item.UnitPrice
                                    };
                existingsale.SaleItems.Add(saleitemlist);
            }

          await _dataContext.SaveChangesAsync();
            return existingsale;
  
        }
    }
}