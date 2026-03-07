using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
   public interface IPurchaseItemService
    {
        Task<ResponseDataModel<List<PurchaseItem>>> GetAllPurchaseItem();

        Task<ResponseDataModel<PurchaseItem>> GetById(int id);

        Task<ResponseDataModel<bool>> DeletePurchaseItem(int id);

        Task<ResponseDataModel<PurchaseItem>> UpdatePurchaseItem(int id, PurchaseItem model);


        Task<ResponseDataModel<PurchaseItem>> AddPurchaseItem(PurchaseItem model);
    }
}
