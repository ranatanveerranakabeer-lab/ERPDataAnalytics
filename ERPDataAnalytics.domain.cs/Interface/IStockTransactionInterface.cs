using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
    public interface IStockTransactionInterface
    {
        Task<List<StockTransaction>> GetStockTransactionList();

        Task<StockTransaction> GetStockTransactionById(int id);


        Task  CreateStockTransaction(StockTransaction model);


        Task<StockTransaction> DeleteStockTransaction(int id);

        Task UpdateStockTransaction(StockTransaction model);
    }
}
