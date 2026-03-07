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
    public class StockTransanctionRepository : IStockTransactionInterface
    {
        private readonly DataContext _dataContext;
        public StockTransanctionRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task CreateStockTransaction(StockTransaction model)
        {
            await _dataContext.StockTransactions.AddAsync(model);
            await _dataContext.SaveChangesAsync();

        }

        public async Task<StockTransaction> DeleteStockTransaction(int id)
        {
            var res = await _dataContext.StockTransactions.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _dataContext.StockTransactions.Remove(res);
                await _dataContext.SaveChangesAsync();
            }
            return null;
        }

        public async Task<StockTransaction> GetStockTransactionById(int id)
        {
            return await _dataContext.StockTransactions.FindAsync(id);
        }

        public async Task<List<StockTransaction>> GetStockTransactionList()
        {
            return await _dataContext.StockTransactions.ToListAsync();
        }

        public async Task UpdateStockTransaction(StockTransaction model)
        {
            var updatedata = await _dataContext.StockTransactions.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.TransactionType = model.TransactionType;
                updatedata.TransactionDate = DateTime.Now;
                updatedata.Quantity = model.Quantity;
                updatedata.BranchId = model.BranchId;

                _dataContext.StockTransactions.Update(updatedata);
                await _dataContext.SaveChangesAsync();





            }
        }
    }
}