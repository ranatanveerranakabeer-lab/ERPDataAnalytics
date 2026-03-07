using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
    public interface IStockTransactionService
    {
        Task<ResponseDataModel<List<StockTransaction>>> GetAllStockTransaction();

        Task<ResponseDataModel<StockTransaction>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteStockTransaction(int id);

        Task<ResponseDataModel<StockTransaction>> UpdateStockTransaction(int id, StockTransaction model);


        Task<ResponseDataModel<StockTransaction>> AddStockTransaction(StockTransaction model);
    }
}
