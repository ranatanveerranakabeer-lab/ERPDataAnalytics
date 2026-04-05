using ERPDataAnalytics.domain.cs.Entities;
using ERPDataAnalytics.domain.cs.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
            await _dataContext.Sales.AddAsync(model);
            await _dataContext.SaveChangesAsync();
            return model;
        }

        public async Task<bool> DeleteSale(int id)
        {
            var res = await _dataContext.Sales.FindAsync(id);
            if (res == null)
                return false;

            _dataContext.Sales.Remove(res);
            await _dataContext.SaveChangesAsync();
            return true;
        }

        public async Task<Sale> GetSaleById(int id)
        {
            return await _dataContext.Sales
                .Include(x => x.SaleItems) 
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Sale>> GetSaleList()
        {
            return await _dataContext.Sales
                .Include(x => x.SaleItems)
                .ToListAsync();
        }

        public async Task<Sale> UpdateSale(Sale model)
        {
            var existingSale = await _dataContext.Sales
                .Include(x => x.SaleItems)
                .FirstOrDefaultAsync(x => x.Id == model.Id);

            if (existingSale == null)
                return null;

            existingSale.CompanyId = model.CompanyId;
            existingSale.BranchId = model.BranchId;
            existingSale.InvoiceNumber = model.InvoiceNumber;
            existingSale.CustomerId = model.CustomerId;
            existingSale.SaleDate = model.SaleDate;
            existingSale.DiscountAmount = model.DiscountAmount;
            existingSale.PaidAmount = model.PaidAmount;

            var total = model.SaleItems.Sum(x => x.Quantity * x.UnitPrice);
            existingSale.TotalAmount = total;
            existingSale.NetAmount = total - existingSale.DiscountAmount;

            foreach (var item in model.SaleItems)
            {
                var existingItem = existingSale.SaleItems
                    .FirstOrDefault(x => x.Id == item.Id);

                if (existingItem != null)
                {
                    existingItem.ProductId = item.ProductId;
                    existingItem.Quantity = item.Quantity;
                    existingItem.UnitPrice = item.UnitPrice;
                    existingItem.Total = item.Quantity * item.UnitPrice;
                }
                else
                {
                    existingSale.SaleItems.Add(new SaleItem
                    {
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        UnitPrice = item.UnitPrice,
                        Total = item.Quantity * item.UnitPrice
                    });
                }
            }

            await _dataContext.SaveChangesAsync();

            return existingSale;
        }
    }
}