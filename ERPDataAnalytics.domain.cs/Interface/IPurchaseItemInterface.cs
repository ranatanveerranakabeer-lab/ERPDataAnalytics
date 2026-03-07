using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
   public interface IPurchaseItemInterface
    {
        Task<List<PurchaseItem>> GetPurchaseItemList();

        Task<PurchaseItem> GetPurchaseItemById(int id);


        Task CreatePurchaseItem(PurchaseItem model);


        Task<PurchaseItem> DeletePurchaseItem(int id);

        Task UpdatePurchaseItem(PurchaseItem model);
    }
}
