using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
    public interface ISaleItemService
    {
        Task<ResponseDataModel<List<SaleItem>>> GetAllSaleItem();

        Task<ResponseDataModel<SaleItem>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteSaleItem(int id);

        Task<ResponseDataModel<SaleItem>> UpdateSaleItem(int id, SaleItem model);


        Task<ResponseDataModel<SaleItem>> AddSaleItem(SaleItem model);
    }
}
