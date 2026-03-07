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
    public class ProductRepository : IProductInterface
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public async Task<Product> DeleteProduct(int id)
        {
            var res = await _context.Products.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Products.Remove(res);
                await _context.SaveChangesAsync();
            }
            return null;
        }
        public async Task CreateProduct(Product model)
        {
            await _context.Products.AddAsync(model);
            await _context.SaveChangesAsync();

        }
        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<List<Product>> GetProductList()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task UpdateProduct(Product model)
        {
            var updatedata = await _context.Products.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.ProductName = model.ProductName;
                updatedata.SalePrice = model.SalePrice;
                updatedata.CostPrice = model.CostPrice;
                updatedata.StockQuantity = model.StockQuantity;
                updatedata.SKU=model.SKU;
                updatedata.CategoryId=model.CategoryId;
                updatedata.CompanyId=model.CompanyId;
                updatedata.IsActive=model.IsActive; 
                _context.Products.Update(updatedata);
                await _context.SaveChangesAsync();

            }
        }
    }
}
