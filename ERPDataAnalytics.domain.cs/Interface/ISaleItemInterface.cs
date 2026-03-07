using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
    public interface ISaleItemInterface
    {
        Task<List<SaleItem>> GetSaleItemList();

        Task<SaleItem> GetSaleItemById(int id);


        Task CreateSaleItem(SaleItem model);


        Task<SaleItem> DeleteSaleItem(int id);

        Task UpdateSaleItem(SaleItem model);
    }
}
