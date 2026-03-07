using ERPDataAnalytics.Application.cs.Interface;
using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using ERPDataAnalytics.domain.cs.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Services
{
    public class StockTransactionService : IStockTransactionService
    {
        private readonly IStockTransactionInterface _StockTransactionrepository;

        public StockTransactionService(IStockTransactionInterface StockTransactionInterface)
        {
            _StockTransactionrepository = StockTransactionInterface;
        }

        public Task<ResponseDataModel<StockTransaction>> AddStockTransaction(StockTransaction model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteStockTransaction(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<StockTransaction>>> GetAllStockTransaction()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<StockTransaction>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<StockTransaction>> UpdateStockTransaction(int id, StockTransaction model)
        {
            throw new NotImplementedException();
        }
    }
}
